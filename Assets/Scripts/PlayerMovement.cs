using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//控制玩家移动
public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;

    public float walkSpeed = 10f;  //行走速度
    public float runSpeed = 15f;  //奔跑速度
    public float speed;

    public bool isRun;//判断是否奔跑
    public bool isJump;

    public bool isWalk;//判断是否在行走

    private bool isGround;

    public float slopeForce = 6.0f; //走斜坡施加的力度
    public float slopeForceRayLength = 2.0f; //斜坡射线的长度

    public float jumpForce = 3f;//跳跃力度
    public Vector3 velocity;//设置玩家Y轴的1个冲量变化
    public float gravity = -9f;
    private Transform groundCheck;
    private float groundDistance = 0.1f;//与地面的距离
    public LayerMask groundMash;

    public Vector3 moveDirction;

    [Header("声音设置")]
    public AudioSource audioSource;
    public AudioClip walkingSound;
    public AudioClip runningSound;


    [Header("键位设置")]
    [Tooltip("奔跑按键")]public KeyCode runInputName;
    [Tooltip("跳跃按键")] public KeyCode jumpInputName = KeyCode.Space;//public string jumpInputName="Jump"; //

    public float maxHealth = 200f;
    private float _currentHealth;

    private bool _isBossAttack;


    // Start is called before the first frame update
    private void Start()
    {
        //获取player身上的CharacterController组件
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
        groundCheck=GameObject.Find("Player/CheckGround").GetComponent<Transform>();

        _currentHealth = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckGround();
        Move();
    }
    //移动
    public void Move()
    {
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");

        isRun=Input.GetKey(runInputName);
        isWalk = (Mathf.Abs(h)>0||Mathf.Abs(v)>0)?true:false;//获取绝对值


        if (isRun)
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        //speed=isRun?runSpeed:walkSpeed;
        moveDirction=(transform.right*h+transform.forward *v).normalized;
        characterController.Move(moveDirction*speed*Time.deltaTime);

        if (_isBossAttack)   /////Boss攻击使人物弹开（未生效）
        {
            moveDirction += transform.forward * -5;
        }

        if (isGround==false)   //不在地面(空中累加向下的重力)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        
        characterController.Move(velocity * Time.deltaTime); //给player施加一个向上的力，跳跃力和重力
        Jump();
        //如果处在斜坡上移动
        if (OnSlpe())
        {
            //向下增加力
            characterController.Move(Vector3.down * characterController.height / 2 * slopeForce * Time.deltaTime);
        }
    }

    public void PlayFootStepSound()
    {
        if (isGround && moveDirction.sqrMagnitude > 0.9f)
        {
            audioSource.clip = isRun ? runningSound : walkingSound;//设置行走或奔跑音效
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }

        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }
    }

    public void Jump()
    {
        isJump = Input.GetKey(jumpInputName);//isJump = Input.GetButtonDown(jumpInputName); //
        if (isJump&&isGround)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f*gravity);
        }
    }

    public void CheckGround()
    {
        //在groundCheck位置上做1个球体检测。判断是否在地面上
        isGround=Physics.CheckSphere(groundCheck.position,groundDistance,groundMash);

        if (isGround&&velocity.y<=0)
        {
            velocity.y = -2f; 
        }
    }

    public bool OnSlpe()
    {
        if (isJump) return false;

        RaycastHit hit;
        //向下打出射线（检测是否在斜坡上）

        if (Physics.Raycast(transform.position, Vector3.down, out hit, characterController.height / 2 * slopeForceRayLength))
        {
            //如果接触到的点的法线，不在（0，1，0）方向上，那么任务就在斜坡上
            if (hit.normal != Vector3.up)
            {
                return true;
            }
        }
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        OnHitPlayer(other);
    }

    private void OnCollisionEnter(Collision other)
    {
        OnHitPlayer(other.collider);
    }


    private void OnHitPlayer(Collider other)  //角色受到攻击
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Bullet enemyBullet = other.GetComponent<Bullet>();
            _currentHealth -= enemyBullet.damage;

            StartCoroutine(routine: OnDamage());

            if (other.GetComponent<Rigidbody>())  //若子弹还存在则销毁
            {
                Destroy(other.gameObject);
            }
        }


        if (other.CompareTag("MeleeArea"))
        {

            MeleeAttacker meleeAttacker = other.GetComponent<MeleeAttacker>();
            _currentHealth -= meleeAttacker.damage;

            //_currentHealth -= 10;
            print(message: "Player got hit by enemy melee");


            _isBossAttack = other.name == "Boss Melee Area";
            StartCoroutine(routine: OnDamage());

        }
    }

    IEnumerator OnDamage()
    {
        print(message: "Current Player Health: " + _currentHealth);

        if (_currentHealth <= 0)
        {
            OnDie();
        }

        yield return new WaitForSeconds(0.2f);
        _isBossAttack = false;
    }

    private void OnDie()
    {
        SceneManager.LoadScene("SampleScene");
    }

   

}

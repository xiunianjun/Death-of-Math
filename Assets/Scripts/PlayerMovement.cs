using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//��������ƶ�
public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;

    public float walkSpeed = 10f;  //�����ٶ�
    public float runSpeed = 15f;  //�����ٶ�
    public float speed;

    public bool isRun;//�ж��Ƿ���
    public bool isJump;

    public bool isWalk;//�ж��Ƿ�������

    private bool isGround;

    public float slopeForce = 6.0f; //��б��ʩ�ӵ�����
    public float slopeForceRayLength = 2.0f; //б�����ߵĳ���

    public float jumpForce = 3f;//��Ծ����
    public Vector3 velocity;//�������Y���1�������仯
    public float gravity = -9f;
    private Transform groundCheck;
    private float groundDistance = 0.1f;//�����ľ���
    public LayerMask groundMash;

    public Vector3 moveDirction;

    [Header("��������")]
    public AudioSource audioSource;
    public AudioClip walkingSound;
    public AudioClip runningSound;


    [Header("��λ����")]
    [Tooltip("���ܰ���")]public KeyCode runInputName;
    [Tooltip("��Ծ����")] public KeyCode jumpInputName = KeyCode.Space;//public string jumpInputName="Jump"; //

    public float maxHealth = 200f;
    private float _currentHealth;

    private bool _isBossAttack;


    // Start is called before the first frame update
    private void Start()
    {
        //��ȡplayer���ϵ�CharacterController���
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
    //�ƶ�
    public void Move()
    {
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");

        isRun=Input.GetKey(runInputName);
        isWalk = (Mathf.Abs(h)>0||Mathf.Abs(v)>0)?true:false;//��ȡ����ֵ


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

        if (_isBossAttack)   /////Boss����ʹ���ﵯ����δ��Ч��
        {
            moveDirction += transform.forward * -5;
        }

        if (isGround==false)   //���ڵ���(�����ۼ����µ�����)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        
        characterController.Move(velocity * Time.deltaTime); //��playerʩ��һ�����ϵ�������Ծ��������
        Jump();
        //�������б�����ƶ�
        if (OnSlpe())
        {
            //����������
            characterController.Move(Vector3.down * characterController.height / 2 * slopeForce * Time.deltaTime);
        }
    }

    public void PlayFootStepSound()
    {
        if (isGround && moveDirction.sqrMagnitude > 0.9f)
        {
            audioSource.clip = isRun ? runningSound : walkingSound;//�������߻�����Ч
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
        //��groundCheckλ������1�������⡣�ж��Ƿ��ڵ�����
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
        //���´�����ߣ�����Ƿ���б���ϣ�

        if (Physics.Raycast(transform.position, Vector3.down, out hit, characterController.height / 2 * slopeForceRayLength))
        {
            //����Ӵ����ĵ�ķ��ߣ����ڣ�0��1��0�������ϣ���ô�������б����
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


    private void OnHitPlayer(Collider other)  //��ɫ�ܵ�����
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Bullet enemyBullet = other.GetComponent<Bullet>();
            _currentHealth -= enemyBullet.damage;

            StartCoroutine(routine: OnDamage());

            if (other.GetComponent<Rigidbody>())  //���ӵ�������������
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

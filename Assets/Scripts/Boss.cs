using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : Enemy
{
    public bool isLook;

    public GameObject missileBoss;
    public Transform missilePortA;
    public Transform missilePortB;


    private Vector3 _lookVec;
    private BoxCollider _boxCollider;
    private Vector3 _jumpHitTarget;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        //_health=GetComponent<Health>();
        _boxCollider = GetComponent<BoxCollider>();


        _navMeshAgent.isStopped = true;

        //StartCoroutine(routine: MissileShot());
        StartCoroutine(routine: Think());
    }

    private void Update()
    {
        /* if(_health,isDead)
         {
             StopAllCoroutines();  死亡时停止进程
         } */

        if (isLook) //视角锁定玩家
        {
            float horizon = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            _lookVec = new Vector3(x: horizon, y: 0, z: vertical) * 5f;
            transform.LookAt(worldPosition: target.position + _lookVec);
        }
        else
        {
            _navMeshAgent.SetDestination(_jumpHitTarget);
        }

    }

    private IEnumerator Think()  //随机两种攻击模式
    {
        yield return new WaitForSeconds(0.1f);

        int ranAction = UnityEngine.Random.Range(0,5);

        switch (ranAction)
        {
            case 0: case 1: case 2: case 3:
                StartCoroutine(routine: MissileShot());
                break;
            case 4:
                StartCoroutine(routine: JumpHit());
                break;
        }
    }



    private IEnumerator MissileShot()
    {
        _animator.SetTrigger(name:"doShot");

        yield return new WaitForSeconds(0.2f);
        GameObject instantMissileA = Instantiate(missileBoss, missilePortA.position, missilePortA.rotation);
        MissileBoss missileBossA = instantMissileA.GetComponent<MissileBoss>();
        missileBossA.target = target;

        yield return new WaitForSeconds(0.2f);
        GameObject instantMissileB = Instantiate(missileBoss, missilePortB.position, missilePortB.rotation);
        MissileBoss missileBossB = instantMissileB.GetComponent<MissileBoss>();
        missileBossB.target = target;

        yield return new WaitForSeconds(2.5f);

        StartCoroutine(routine: Think());
    }

    private IEnumerator JumpHit()
    {
        _jumpHitTarget = target.position + _lookVec;

        isLook = false; //取消视角锁定
        _navMeshAgent.isStopped = false;
        _boxCollider.enabled = false;

        _animator.SetTrigger(name: "doJumpHit");

        yield return new WaitForSeconds(1.5f);
        meleeArea.enabled = true;

        yield return new WaitForSeconds(0.5f);
        meleeArea.enabled = false;

        yield return new WaitForSeconds(1f);

        isLook = true;//恢复视角锁定
        _navMeshAgent.isStopped = true;
        _boxCollider.enabled = true;

        yield return new WaitForSeconds(2f);
        StartCoroutine(routine: Think());

    }


}

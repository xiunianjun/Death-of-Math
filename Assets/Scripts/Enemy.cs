using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public enum Type {Melee,Range,Boss};

    public Type enemyType;

    public Transform target;
    public BoxCollider meleeArea;

    public GameObject bullet;

    protected Rigidbody _rigidbody;
    protected NavMeshAgent _navMeshAgent;
    protected Animator _animator;

    private float _targetRadius;
    private float _targetRange;

    private bool _isChase;
    private bool _isAttack;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();


        if (enemyType != Type.Boss)
        {
            Invoke(methodName: "ChaseStart", time: 2);
        }
        
    }
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    private void FreeVelocity()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (_health.isDead)
        {
            StopAllCoroutines();
        }*/



        if (_navMeshAgent.enabled&&enemyType!=Type.Boss)
        {
            _navMeshAgent.SetDestination(target.position);
            _navMeshAgent.isStopped = !_isChase;
        }
    }

    private void ChaseStart()
    {
        _isChase = true;

        if (_animator)
        {
            _animator.SetBool(name: "isWalk",value:true);
        }
    }

    private void FixedUpdate()
    {
        if (_isChase)
        {
            FreeVelocity();
        }
        if(enemyType!=Type.Boss)
            Targeting();

    }

    private void Targeting()
    {
        if (enemyType == Type.Melee)
        {
            _targetRadius = 0.5f;
            _targetRange = 2f;
        }
        else if (enemyType == Type.Range)
        {
            _targetRadius = 0.5f;
            _targetRange = 10f;
        }

        RaycastHit[] hits = Physics.SphereCastAll(origin: transform.position, _targetRadius, direction: transform.forward,
            maxDistance: _targetRange, LayerMask.GetMask( layerNames: "Player"));
        if (hits.Length > 0 && !_isAttack)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        _isChase = false;
        _isAttack = true;

        _animator.SetBool(name: "isAttack", value: true);


        if (enemyType == Type.Melee)
        {
            yield return new WaitForSeconds(0.2f);

            meleeArea.enabled = true;

            yield return new WaitForSeconds(1f);
            meleeArea.enabled = false;

            yield return new WaitForSeconds(1f);
        }
        else if (enemyType == Type.Range)
        {
            yield return new WaitForSeconds(0.5f);

            GameObject instantBullet = Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rigidbodyBullet = instantBullet.GetComponent<Rigidbody>();
            rigidbodyBullet.velocity = transform.forward * 20f;

            yield return new WaitForSeconds(2f);

        }

        _isChase = true;
        _isAttack = false;
        _animator.SetBool(name: "isAttack", value: false);
    }

}

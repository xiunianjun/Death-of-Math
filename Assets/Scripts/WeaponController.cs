using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class WeaponController : MonoBehaviour
{
    public PlayerMovement PM;
    public Transform shooterPoint;//�����λ��

    public int bulletMag=30;//��ϻ����
    public int range = 100;//���������
    public int bulletLeft = 300;//������
    public int currentBullects;//��ǰ��ҩ����

    bool GunShootInput;

    public float fireRate = 0.1f;//����
    private float fireTimer;//��ʱ��


    public ParticleSystem muzzleFlash;//ǹ�ڻ�����Ч
    public Light muzzleFlashLight;//ǹ�ڻ���ƹ�
    public GameObject hitParticle; //�ӵ�����������Ч
    public GameObject bullectHole; //����
    /*��Ч����*/
    private AudioSource audioSource;
    public AudioClip AK47SoundClip;//�����ЧƬ��
    public AudioClip reloadAmmoLeftClip;//���ӵ�1��Ч
    public AudioClip reloadAmmoOutClip;//���ӵ�2��Ч

    private bool isReload;//�ж��Ƿ���װ��
    private bool isAiming;//�ж��Ƿ���׼


    [Header("��λ����")]
    [SerializeField][Tooltip("��װ�ӵ�����")]private KeyCode reloadInputName;
    [SerializeField] [Tooltip("������������")] private KeyCode inspectInputName;

    [Header("UI����")]
    public Image CrossHairUI;
    public Text AmmoTextUI;

    private Animator anim;
    private Camera mainCamera;

    //�˺�
    public float damage = 20f;


    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        reloadInputName = KeyCode.R;
        inspectInputName = KeyCode.N;
        currentBullects = bulletMag;
        UpdateAmmoUI();

        
    }

    // Update is called once per frame
    void Update()
    {
        GunShootInput = Input.GetMouseButton(0);   //0Ϊ������ 1Ϊ����Ҽ�  2Ϊ����м�  ����������Ƿ�����
        if (GunShootInput)
        {
            GunFire();
        }
        else
        {
            muzzleFlashLight.enabled = false;
        }

        AnimatorStateInfo info=anim.GetCurrentAnimatorStateInfo(0);

        if (info.IsName("reload_ammo_left") || info.IsName("reload_out_of_ammo"))
        {
            isReload = true;
        }
        else
        {
            isReload = false;
        }

        if (Input.GetKeyDown(reloadInputName) && currentBullects < bulletMag && bulletLeft>0)
        {
            
            DoReloadAnimation();
            Reload();
        }
        DoingAim();
        if (Input.GetKeyDown(inspectInputName))//���ò鿴��������
        {
            anim.SetTrigger("Inspect");
        }
        anim.SetBool("Run",PM.isRun);
        anim.SetBool("Walk", PM.isWalk);

        if (fireTimer < fireRate)
        {
            fireTimer+=Time.deltaTime;
        }

    }

    public void GunFire()  //
    {
        
       


        //�������٣����ʱ��ֵ������С������������ִ��
        //ÿ֡��������ִ�еĴ������Ӷ�ʵ�����ٿ���
        if (fireTimer < fireRate||currentBullects<=0||isReload||PM.isRun) return;

        RaycastHit hit;
        Vector3 shootDirection = shooterPoint.forward;//���������ǰ��
        if (Physics.Raycast(shooterPoint.position, shootDirection, out hit, range)) //�ж����
        {
            GameObject hitParticleEffect = Instantiate(hitParticle, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal)); //ʵ�����ӵ����е���Ч
            GameObject bullectHoleEffect = Instantiate(bullectHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));//ʵ����������Ч

            //������Ч
            Destroy(hitParticleEffect, 1f);
            Destroy(bullectHoleEffect, 3f);
        }
        if (!isAiming)
        {
            anim.CrossFadeInFixedTime("fire", 0.1f);  //������ͨ���𶯻����������뵭��Ч����
        }
        else
        {
            anim.CrossFadeInFixedTime("aim_fire", 0.1f); //��׼״̬�²��ſ��𶯻�
        }
        


        PlayerShootSound();//���������Ч
        muzzleFlash.Play();//���Ż����Ч
        muzzleFlashLight.enabled = true;
        currentBullects--;
        UpdateAmmoUI();
        fireTimer = 0f;//���ü�ʱ��

    }

    public void Reload()
    {
        if (bulletLeft <= 0) return;

        int bullectToLoad = bulletMag - currentBullects; //������Ҫ��װ���ӵ���
        int bullectToReduce=(bulletLeft >= bullectToLoad) ? bullectToLoad : bulletLeft;
        bulletLeft -= bullectToReduce;
        currentBullects += bullectToLoad;
        UpdateAmmoUI();
    }

    public void DoReloadAnimation()  //����װ���
    {
        if (currentBullects > 0)
        {
            anim.Play("reload_ammo_left", 0,0); //���Ŷ���1
            audioSource.clip = reloadAmmoLeftClip;
            audioSource.Play();
        }
        if (currentBullects == 0)
        {
            anim.Play("reload_out_of_ammo", 0, 0);//���Ŷ���2
            audioSource.clip = reloadAmmoOutClip;
            audioSource.Play();
        }
    }


    public void PlayerShootSound()
    {
        audioSource.clip = AK47SoundClip;
        audioSource.Play();
    }

    public void DoingAim()
    {
        if(Input.GetMouseButton(1)&&!isReload&&!PM.isRun)
        {
            //��׼
            isAiming = true;
            anim.SetBool("Aim", true);
            CrossHairUI.gameObject.SetActive(false);
            mainCamera.fieldOfView = 25;//��׼ʱ�������Ұ��С��������
        }
        else
        {
            isAiming = false;
            anim.SetBool("Aim", false);
            CrossHairUI.gameObject.SetActive(true);
            mainCamera.fieldOfView = 60;//�������Ұ���
        }
        
    }

    public void UpdateAmmoUI()
    {
        AmmoTextUI.text = currentBullects + "/" + bulletLeft;
    }



}

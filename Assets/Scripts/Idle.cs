using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D;
using Live2D.Cubism.Core;

public class Idle : MonoBehaviour
{

    public AudioClip[] audios;
    public AudioSource audioSource;
    public Animator animator;
    public float interval = 15f;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isSleep", false);
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&audioSource.isPlaying==false&&animator.GetBool("isSleep")==false)
        {
            int random = Random.Range(0, audios.Length);
            audioSource.clip = audios[random];
            audioSource.Play();
            timer = 0;
        }
        if (Input.GetMouseButton(0))
        {
            
        }
        else
        {
            if(audioSource.isPlaying==false)
                timer += Time.deltaTime;
        }

        if (timer >= interval)
        {
            animator.SetBool("isSleep", true);
            timer = -15;
            
        }
        if (timer >= 1)
        {
            animator.SetBool("isSleep", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnMouseClick : MonoBehaviour
{
    public float fadeSpeed = 0.1f;
    public Image mask;
    private float timer = 0;
    public Image closeImage;
    public Image openImage;
    private void Awake()
    {
        mask.color = new Color(255,255,255,0);
        timer = 0;
        closeImage.enabled = true;
        openImage.enabled = false;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (openImage.enabled == true)
        {
            timer += Time.deltaTime;
            if (timer >= 0.5f)
            {
                StartCoroutine(ToLight());
                
            }
        }
    }

    private IEnumerator ToLight()
    {
       float timer2 = 0;
        while (mask.color != Color.white)
        {
            timer2 += Time.deltaTime;
            mask.color = Color.Lerp(mask.color, Color.white,  fadeSpeed* timer2);
            yield return null;
        }
        SceneManager.LoadScene("µçÄÔ");
        //yield return null;
    }

    private void OnMouseDown()
    {
        closeImage.enabled = false;
        openImage.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToPlayMusic : MonoBehaviour
{
    AudioSource audio;
    public List<AudioClip> audioClips=new List<AudioClip>();
    int index = 0;
    int max = 0;
    bool isPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        isPlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isPlay == true)
            {
                isPlay = false;
                audio.Stop();
            }
            else
            {
                max = audioClips.Count;
                if (index >= 0 && index < max)
                {
                    audio.clip = audioClips[index];
                    index++;
                }
                else
                {
                    index = 0;
                }
                audio.Play();
                isPlay = true;
            }
        }
    }
}

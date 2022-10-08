using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDeskTop : MonoBehaviour
{
    AudioSource audio;
    public List<AudioClip> audioClips = new List<AudioClip>();
    private Image _image;
    //×ÀÃæÍ¼Æ¬
    public Sprite[] pictures;

    
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = audioClips[Random.Range(0, audioClips.Count)];
        audio.Play();
        _image = gameObject.GetComponent<Image>();
        _image.sprite = pictures[Random.Range(0, pictures.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

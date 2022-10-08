using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextContent : MonoBehaviour
{

    public Dialogue dialogue;
    public Dialogue.Characters character;
    public string content;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (dialogue.gameObject.activeSelf == true)
        {
            return;
        }
        dialogue.gameObject.SetActive(true);
        StartCoroutine(dialogue.DisplayDialogue(content, character));
        
    }
}

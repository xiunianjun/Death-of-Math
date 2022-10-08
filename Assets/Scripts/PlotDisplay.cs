using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotDisplay : MonoBehaviour
{

    public Dialogue dialogue;
    public Plot plot;

    // Start is called before the first frame update
    void Start()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator DisplayPlot(string plotName)
    {
        string[] texts=plot.LoadTextContent(plotName);
        for(int i = 0; i < texts.Length; i++)
        {
            string[] imfor = texts[i].Split('£º');
            string character;
            string content;
            if (imfor.Length <= 1)
            {
                character = "ÎÞ";
                content = imfor[0];
            }
            else
            {
                character = imfor[0];
                content = imfor[1];
            }
            
            yield return dialogue.DisplayDialogue(content,character);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    private TextAsset text = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  string[] LoadTextContent(string diaName)
    {
        load(diaName);
        return text.text.Split('\n');
    }

    private void load(string str)
    {
        string textName = "ÎÄ°¸/" + str ;
        text = Resources.Load<TextAsset>(textName);
    }
}

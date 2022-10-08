using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOnButton : MonoBehaviour
{
    private Outline outline;
    // Start is called before the first frame update
    void Start()
    {
        outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        if (outline != null)
        {
            outline.enabled = true;
        }
        System.Console.WriteLine("I am in!");
    }
    private void OnMouseExit()
    {
        if (outline != null)
        {
            outline.enabled = false;
        }
        System.Console.WriteLine("I am out!");
    }
}

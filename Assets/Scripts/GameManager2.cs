using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    PlotDisplay plotDisplay;
    // Start is called before the first frame update
    void Start()
    {
        plotDisplay = gameObject.GetComponent<PlotDisplay>();
        StartCoroutine(plotDisplay.DisplayPlot("Meet_Ganyu1"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerManager : MonoBehaviour
{
    public float fadeSpeed = 0.1f;
    public Image mask;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        mask.color = Color.white;
        StartCoroutine(ToNormal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator ToNormal()//”ÎToLight∂‘”¶
    {
        while (mask.color != new Color(255,255,255,0))
        {
            System.Console.WriteLine(mask.color);
            mask.color = Color.Lerp(mask.color, new Color(255, 255, 255, 0), Time.deltaTime * fadeSpeed);
            yield return null;
        }
    }
}

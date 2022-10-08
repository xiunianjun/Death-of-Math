using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Motion;

public class Motion_Player : MonoBehaviour
{

    CubismMotionController motionController;
    // Start is called before the first frame update
    void Start()
    {
        motionController = gameObject.GetComponent<CubismMotionController>();
        
    }

    public void PlayMotion(AnimationClip animation)
    {
        if (motionController == null || animation == null) return;
        motionController.PlayAnimation(animation, isLoop: false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//摄像机的旋转
//
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;  //视线灵敏度
    public Transform playerBody;  //玩家当前位置
    public float xRotation=0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //将光标锁定在该游戏窗口的中心（隐藏光标）
    }

    // Update is called once per frame
    void Update()
    {
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f); //限制轴值的累计
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);//玩家横向旋转
    }
}

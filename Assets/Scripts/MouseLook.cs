using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���������ת
//
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;  //����������
    public Transform playerBody;  //��ҵ�ǰλ��
    public float xRotation=0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //����������ڸ���Ϸ���ڵ����ģ����ع�꣩
    }

    // Update is called once per frame
    void Update()
    {
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f); //������ֵ���ۼ�
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);//��Һ�����ת
    }
}

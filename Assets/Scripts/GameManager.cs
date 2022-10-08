using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    Plot plot;
    private AudioSource audio;
    public AudioClip footPrint;//�Ų�
    public AudioClip doorOpen;//����
    public AudioClip textClip;//����
    
    public Image backGround;//��ɫ����
    public Text text;//��Ļ
    
    public float fadeSpeed;//����ɫ��ɰ�ɫ���ٶ�
    public float perCharSpeed = 1;//�ֳ����ٶ�

    private string[] stringList;//�洢��ǰ��Ļ����
    
    void Start()
    {
        plot = gameObject.GetComponent<Plot>();
        audio = gameObject.GetComponent<AudioSource>();
        backGround.gameObject.SetActive(true);

        stringList = plot.LoadTextContent("Main_Begin1");

        StartCoroutine(BeforeGetOut());
    }

    IEnumerator BeforeGetOut()
    {
        yield return DisplayTexts();//��ʾ�ı�����
        //�˴������ֻ���Ļ����ͼƬ
        stringList = plot.LoadTextContent("Main_Begin2");
        yield return DisplayTexts();
        audio.loop = false;//����������������Ҫѭ��
        yield return new WaitForSeconds(2);
        yield return DispayEnvironmentAudio();//���Ż�����
        yield return DisplayScreenToClear();//������Ļ����Ч��
        SceneManager.LoadScene("��������");//�л�����һ����
        yield return new WaitForSeconds(2);
        backGround.gameObject.SetActive(false);
    }

    IEnumerator DisplayTexts()
    {
        text.gameObject.SetActive(true);
        int textCount = 0;
        audio.loop = true;
        audio.clip = textClip;
        while (textCount < stringList.Length)
        {
            yield return DisplayCha(stringList[textCount++]);//������ʾһ���ַ���
            while (!Input.anyKeyDown)//û���������ʱͣ���ı�
            {
                yield return null;
            }
        }
        text.gameObject.SetActive(false);//�ر��ı���
    }
    IEnumerator DispayEnvironmentAudio()
    {
        audio.clip = footPrint;
        audio.Play();
        yield return new WaitForSeconds(8);
        audio.Stop();
        yield return new WaitForSeconds(3);
        audio.clip = doorOpen;
        audio.Play();
        yield return new WaitForSeconds(2);
        audio.Stop();
    }
    IEnumerator DisplayScreenToClear()
    {
        float timer2 = 0;
        while (backGround.color!=Color.white)
        {
            timer2 += Time.deltaTime;
            backGround.color = Color.Lerp(backGround.color,Color.white, fadeSpeed * timer2);
            yield return null;
        }
        yield return null;
    }
    IEnumerator DisplayCha(string words)
    {
        float timer = 0;
        bool isPrint = true;
        audio.Play();
        while (isPrint)
        {
            text.text = words.Substring(0, (int)(perCharSpeed * timer));//��ȡ
            timer += Time.deltaTime;
            yield return null;
            if (text.text == words)
            {
                isPrint = false;
            }
        }
        audio.Stop();
        yield return null;
    }
}

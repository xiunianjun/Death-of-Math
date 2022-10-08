using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    Plot plot;
    private AudioSource audio;
    public AudioClip footPrint;//脚步
    public AudioClip doorOpen;//开门
    public AudioClip textClip;//打字
    
    public Image backGround;//黑色画面
    public Text text;//字幕
    
    public float fadeSpeed;//最后黑色变成白色的速度
    public float perCharSpeed = 1;//字出现速度

    private string[] stringList;//存储当前字幕内容
    
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
        yield return DisplayTexts();//显示文本内容
        //此处插入手机屏幕亮起图片
        stringList = plot.LoadTextContent("Main_Begin2");
        yield return DisplayTexts();
        audio.loop = false;//其他环境声音不需要循环
        yield return new WaitForSeconds(2);
        yield return DispayEnvironmentAudio();//播放环境音
        yield return DisplayScreenToClear();//播放屏幕渐黑效果
        SceneManager.LoadScene("甘雨相遇");//切换到下一场景
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
            yield return DisplayCha(stringList[textCount++]);//逐字显示一串字符串
            while (!Input.anyKeyDown)//没按下任意键时停留文本
            {
                yield return null;
            }
        }
        text.gameObject.SetActive(false);//关闭文本框
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
            text.text = words.Substring(0, (int)(perCharSpeed * timer));//截取
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    //private static Dialogue _instance ;
    //public static Dialogue GetInstance
    //{
    //    get
    //    {
    //        return _instance;
    //    }
    //}
    //private Dialogue()
    //{

    //}
    public float perCharSpeed = 1;//�ֳ����ٶ�
    
    public AudioSource audio;
    public AudioClip textClip;
    public List<AudioClip> GANYUaudioClips = new List<AudioClip>();
    public List<AudioClip> KELIaudioClips = new List<AudioClip>();
    public List<AudioClip> YINGaudioClips = new List<AudioClip>();
    public List<AudioClip> YOULAaudioClips = new List<AudioClip>();
    private List<AudioClip> audioClips = null;

    public Text characterNameText;
    public Text dialogueText;
    Color color = Color.clear;
    

    public enum Characters
    {
        GANYU,
        KELI,
        YING,
        YOULA,
        PLAYER,
        NULL
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator DisplayDialogue(string content, string character)
    {
        bool isPlyaer = false;
        Characters chara;
        switch (character)
        {
            case "����":
                audioClips = GANYUaudioClips;
                chara = Characters.GANYU;
                break;
            case "����":
                audioClips = KELIaudioClips;
                chara = Characters.KELI;
                break;
            case "Ӱ":
                audioClips = YINGaudioClips;
                chara = Characters.YING;
                break;
            case "��":
                isPlyaer = true;
                chara = Characters.PLAYER;
                break;
            case "��ǉ":
                audioClips = YOULAaudioClips;
                chara = Characters.YOULA;
                break;
            default:
                isPlyaer = true;
                chara = Characters.NULL;
                break;
        }
        SetCharacterNameText(chara);
        yield return DisplayTexts(content,isPlyaer);
    }
    public IEnumerator DisplayDialogue(string content,Characters character)
    {
        SetCharacterNameText(character);
        yield return DisplayTexts(content,character.Equals(Characters.NULL)||character.Equals(Characters.PLAYER));
    }

    private IEnumerator DisplayTexts(string content,bool isPlayer)
    {
        gameObject.SetActive(true);
        if (isPlayer)
        {
            audio.loop = true;
            audio.clip = textClip;
        }
        else
        {
            audio.loop = false;
            audio.clip = audioClips[Random.Range(0, 4)];
        }
        yield return DisplayCha(content);//������ʾһ���ַ���
        while (!Input.GetKeyDown(KeyCode.Space)&&!Input.GetMouseButtonDown(0))//û���¿ո����������ʱͣ���ı�
        {
            yield return null;
        }
        
        gameObject.SetActive(false);//�ر��ı���
    }
    private IEnumerator DisplayCha(string words)
    {
        float timer = 0;
        bool isPrint = true;
        if(audio.clip!=null)
            audio.Play();
        string s = "";
        while (isPrint)
        {
            int index = (int)(perCharSpeed * timer);
            if (index > words.Length)
            {
                index = words.Length;
                isPrint = false;
            }
            s = words.Substring(0, index);//��ȡ
            System.Console.WriteLine(s);
            s = AddColor(s,color);
            dialogueText.text = s;
            timer += Time.deltaTime;
            yield return null;
            if (dialogueText.text .Equals(words))
            {
                isPrint = false;
            }
        }
        if(audio.clip!=null)
            audio.Stop();
        yield return null;
    }
    private void SetCharacterNameText(Characters character)
    {

        
        string characterName = "";
        switch (character)
        {
            case Characters.NULL:
                color = Color.black;
                characterName = "C:\\:     >";
                break;
            case Characters.PLAYER:
                color = Color.black;
                characterName = "C:\\:��   >";
                break;
            case Characters.GANYU:
                color = new Color(0,100, 255, 255);
                characterName = "C:\\:���� >";
                break;
            case Characters.KELI:
                color = new Color(226, 80, 0, 255);
                characterName = "C:\\:���� >";
                break;
            case Characters.YING:
                color = new Color(70, 0, 226, 255);
                characterName = "C:\\:Ӱ   >";
                break;
            case Characters.YOULA:
                color = new Color(0, 106, 219, 255);
                characterName = "C:\\:��ǉ >";
                break;
            default:
                break;
        }
        characterName = AddColor(characterName, color);
        if (characterName.Equals(""))
        {
            throw new System.Exception("The StringName is NULL!");
        }
        else
        {
            characterNameText.text = characterName;
        }
    }
    private string AddColor(string str, Color color)
    {
        if (color == Color.clear || str.Equals(""))
        {
            return "";
        }
        return string.Format("<color=#{0}>{1}</color>", ColorUtility.ToHtmlStringRGBA(color), str);
    }
}

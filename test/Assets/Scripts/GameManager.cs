using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // gm
    public static GameManager instance;

    // audio source
    public AudioClip audioClip;
    public AudioSource AudioSource;
    public float volume;

    // instantiate player
    public GameObject Player;
    
    // score system
    public float score = 0f;
    public float maxScore;

    // coin system
    public float coin = 0f;

    // instantiate ddong
    public GameObject DdongObj;
    bool isDdongActive = true;
    public float delay;
    float ddongRandX;

    // instantiate coin
    public GameObject Coin1Obj;
    public GameObject Coin10Obj;
    public GameObject Coin100Obj;
    public GameObject Coin500Obj;

    bool isCoin1Active = false;
    bool isCoin10Active = false;
    bool isCoin100Active = false;
    bool isCoin500Active = false;

    public float coin1Times;
    public float coin10Times;
    public float coin100Times;
    public float coin500Times;
    
    float Coin1RandX;
    float Coin10RandX;
    float Coin100RandX;
    float Coin500RandX;

    // game mode
    public float easyDelay;
    public float normalDelay;
    public float hardDelay;
    public float crazyDelay;

    // game start/over
    public GameObject GameOverUI;
    public bool isGameStart = false;
    public bool isGameOver = false;
    public bool isGaming = false;

    // Dont hit Set
    int playerLayer;
    int ddongLayer;
    public float dontHitTime;
  
    // mode set func
    public void EasyModeSet()
    {
        delay = easyDelay;
        isGameStart = true;
}

    public void NormalModeSet()
    {
        delay = normalDelay;
        isGameStart = true;
    }

    public void HardModeSet()
    {
        delay = hardDelay;
        isGameStart = true;
    }

    public void CrazyModeSet()
    {
        delay = crazyDelay;
        isGameStart = true;
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void GameSave()
    {
        PlayerPrefs.SetFloat("Coins", coin);
        PlayerPrefs.SetFloat("MaxScore", maxScore);
        PlayerPrefs.Save();
    }

    public void GameLoad()
    {
        coin = PlayerPrefs.GetFloat("Coins");
        maxScore = PlayerPrefs.GetFloat("MaxScore");
    }

    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        maxScore = score;
        GameLoad();

        AudioSource.clip = audioClip;
        AudioSource.volume = volume;
        playerLayer = LayerMask.NameToLayer("Player");
        ddongLayer = LayerMask.NameToLayer("ddong");     
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isDdongActive) { isDdongActive = false; StartCoroutine(DdongIns()); }
        if (isCoin1Active) { isCoin1Active = false; StartCoroutine(Coin1Ins()); }
        if (isCoin10Active) { isCoin10Active = false; StartCoroutine(Coin10Ins()); }
        if (isCoin100Active) { isCoin100Active = false; StartCoroutine(Coin100Ins()); }
        if (isCoin500Active) { isCoin500Active = false; StartCoroutine(Coin500Ins()); }

        if (isGameStart) 
        {    
            isGameStart = false;
            Instantiate(Player, new Vector2(0, -4), Quaternion.identity);
            StartCoroutine(Donthitddong());           
            isGaming = true;
            score = 0;            
        }
        
        if (isGaming)
        {
            score += Time.deltaTime * 10;
        }

        if (isGameOver)
        {
            isCoin1Active = isCoin10Active = isCoin100Active = isCoin500Active = false;
            isGaming = false; isGameOver = false;
            GameOverUI.SetActive(true); delay = easyDelay;
        }

        if (score > maxScore)
        {
            maxScore = score;
        }

        GameSave();
    }

    // ddong instantiate delay system
    IEnumerator DdongIns()
    {
        ddongRandX = Random.Range(-8.5f, 8.5f);
        Instantiate(DdongObj, new Vector3(ddongRandX, 5, 0), Quaternion.identity);
        yield return new WaitForSeconds(delay);
        isDdongActive = true;
    }

    IEnumerator Coin1Ins()
    {
        Coin1RandX = Random.Range(-8.5f, 8.5f);
        Instantiate(Coin1Obj, new Vector3(Coin1RandX, 5, 0), Quaternion.identity);
        yield return new WaitForSeconds(delay * coin1Times);
        isCoin1Active = true;
    }
    IEnumerator Coin10Ins()
    {
        Coin10RandX = Random.Range(-8.5f, 8.5f);
        Instantiate(Coin10Obj, new Vector3(Coin10RandX, 5, 0), Quaternion.identity);
        yield return new WaitForSeconds(delay * coin10Times);
        isCoin10Active = true;
    }
    IEnumerator Coin100Ins()
    {
        Coin100RandX = Random.Range(-8.5f, 8.5f);
        Instantiate(Coin100Obj, new Vector3(Coin100RandX, 5, 0), Quaternion.identity);
        yield return new WaitForSeconds(delay * coin100Times);
        isCoin100Active = true;
    }
    IEnumerator Coin500Ins()
    {
        Coin500RandX = Random.Range(-8.5f, 8.5f);
        Instantiate(Coin500Obj, new Vector3(Coin500RandX, 5, 0), Quaternion.identity);
        yield return new WaitForSeconds(delay * coin500Times);
        isCoin500Active = true;
    }

    IEnumerator Donthitddong()
    {
        Physics2D.IgnoreLayerCollision(playerLayer, ddongLayer, true);
        yield return new WaitForSeconds(dontHitTime);
        Physics2D.IgnoreLayerCollision(playerLayer, ddongLayer, false);
        isCoin1Active = isCoin10Active = isCoin100Active = isCoin500Active = true;
    }
}

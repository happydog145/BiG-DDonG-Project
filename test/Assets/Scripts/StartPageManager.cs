using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartPageManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    float coin;
    public GameObject menuUI;

    void Awake()
    {
        var objs = FindObjectsOfType<MenuUIManager>();
        Debug.Log(objs.Length);

        if (objs.Length == 1)
        {
            DontDestroyOnLoad(menuUI);
        }
        else
        {
            Destroy(menuUI);
        }      
    }
    // Start is called before the first frame update
    void Start()
    {
        coin = PlayerPrefs.GetFloat("Coins");               
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = string.Format("{0:n0}", coin);
    }

    public void NextScene()
    {        
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);         
    }

    public void SkinPageScene()
    {        
        SceneManager.LoadScene("SkinPageScene", LoadSceneMode.Single);       
    }
}

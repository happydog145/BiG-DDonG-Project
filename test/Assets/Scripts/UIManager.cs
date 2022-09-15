using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI maxScoreText;
    public TextMeshProUGUI scoreLiveText;

    public GameObject menuUI;
    public bool isFullScreen = false;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreLiveText.text = string.Format("{0:n0}", GameManager.instance.score);
        coinText.text = string.Format("{0:n0}", GameManager.instance.coin);
        maxScoreText.text = string.Format("{0:n0}", GameManager.instance.maxScore);

        if (Input.GetButtonDown("Cancel"))
        {
            if(menuUI.activeSelf) menuUI.SetActive(false);
            else menuUI.SetActive(true);
        }     
    }

    public void SetFullScreenBool(bool isFullScreen)
    {
        if (isFullScreen)
        {
            Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow);
        }
        else
        {
            Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        }
    }
}

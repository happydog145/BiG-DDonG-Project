using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI maxScoreText;
    public TextMeshProUGUI scoreLiveText;

    public TextMeshProUGUI EasyScore;
    public TextMeshProUGUI NormalScore;
    public TextMeshProUGUI HardScore;
    public TextMeshProUGUI CrazyScore;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreLiveText.text = string.Format("{0:n0}", GameManager.instance.score);
        coinText.text = string.Format("{0:n0}", GameManager.instance.coin);
        maxScoreText.text = string.Format("{0:n0}", GameManager.instance.maxScore);

        EasyScore.text = string.Format("{0:n0}", GameManager.instance.easyMaxScore);
        NormalScore.text = string.Format("{0:n0}", GameManager.instance.normalMaxScore);
        HardScore.text = string.Format("{0:n0}", GameManager.instance.hardMaxScore);
        CrazyScore.text = string.Format("{0:n0}", GameManager.instance.crazyMaxScore);
    }
}

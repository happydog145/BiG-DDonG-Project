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

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreLiveText.text = string.Format("{0:n0}", GameManager.instance.score);
        coinText.text = string.Format("{0:n0}", GameManager.instance.coin);
        maxScoreText.text = string.Format("{0:n0}", GameManager.instance.maxScore);
    }
}

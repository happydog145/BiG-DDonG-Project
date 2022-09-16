using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAudioManager : MonoBehaviour
{
    public AudioClip mainTheme;
    public AudioClip inGameTheme;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = mainTheme;
        audio.Play();
    }

    public void SetMainTheme()
    {
        audio.clip = mainTheme;
    }

    public void SetInGameTheme()
    {
        audio.clip = inGameTheme;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(0)))
        {
            SetInGameTheme();
        }

        else if (SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1)))
        {
            SetMainTheme();
        }

        else if (SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(2)))
        {
            SetMainTheme();
        }
    }
}

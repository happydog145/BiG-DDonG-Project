using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    Slider slider;
    StartPageManager start;
    // Start is called before the first frame update
    private void Awake()
    {
        start = GetComponent<StartPageManager>();
        slider = GetComponent<Slider>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainPageAudioManager(float volume)
    {
        GameManager.instance.volume = volume;
    }

    public void StartPageAudioManager(float volume)
    {
        start.AudioSource.volume = volume;
    }
}

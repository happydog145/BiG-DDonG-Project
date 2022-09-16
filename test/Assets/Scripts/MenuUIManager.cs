using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainPageAudioManager(float volume)
    {
        GameManager.instance.volume = volume;
    }
}

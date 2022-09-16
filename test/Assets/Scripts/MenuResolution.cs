using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuResolution : MonoBehaviour
{
    public bool isFullScreen = false;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1600, 900, isFullScreen);
    }

    public void GetBoolFullScreen(bool isFull)
    {
        isFull = isFullScreen;
    }

    public void Resoulution1()
    {
        Screen.SetResolution(2560, 1440, isFullScreen);
    }

    public void Resoulution2()
    {
        Screen.SetResolution(1920, 1080, isFullScreen);
    }

    public void Resoulution3()
    {
        Screen.SetResolution(1600, 900, isFullScreen);
    }

    public void Resoulution4()
    {
        Screen.SetResolution(1280, 720, isFullScreen);
    }
}

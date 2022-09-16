using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    Slider slider;
    MenuAudioManager menu;
    public GameObject menuUI;
    // Start is called before the first frame update
    private void Awake()
    {
        slider = GetComponent<Slider>();
        menu = GetComponent<MenuAudioManager>();
    }

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuUI.activeSelf) { menuUI.SetActive(false); }
            else { menuUI.SetActive(true); }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}

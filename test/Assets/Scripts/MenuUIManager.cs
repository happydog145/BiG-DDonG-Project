using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    Slider slider;
    public GameObject menuUI;
    public AudioSource audioSource;
    // Start is called before the first frame update
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        slider = GetComponent<Slider>();
        menuUI.SetActive(false);
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

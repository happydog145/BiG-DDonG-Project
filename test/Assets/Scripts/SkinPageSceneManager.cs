using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SkinPageSceneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public void PageToStartPage()
    {        
        SceneManager.LoadScene("StartPageScene", LoadSceneMode.Single);     
    }
}

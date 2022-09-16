using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
    bool isLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Cancel"))
        {
            if (isLoaded)
            {                
                SceneManager.UnloadSceneAsync("MenuScene");
            }
            else
            {
                SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
                isLoaded = true;
            }
        } 
    }
}

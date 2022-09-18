using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SkinPageTextManager : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    MenuUIManager menuUIManager;
    public AudioClip clip;
    // Start is called before the first frame update

    void Start()
    {
        menuUIManager = GetComponent<MenuUIManager>();     
    }

    public void Skin1Text()
    {
        textMeshPro.text = "�츮���� ���� ģ��";
    }

    public void Skin2Text()
    {
        textMeshPro.text = "Z�ӿ� Z�ӿ� ���۸�";
    }

    public void Skin3Text()
    {
        textMeshPro.text = "����Ʈ�� ���~";
    }

    public void Skin4Text()
    {
        textMeshPro.text = "���������� �ʹ� ���ϰ� ����";
    }

    public void Skin5Text()
    {
        textMeshPro.text = "2���������� ũ������ ��� õ�� �޼�!";
    }

    public void PageToStartPage()
    {        
        SceneManager.LoadScene("StartPageScene", LoadSceneMode.Single);     
    }
}

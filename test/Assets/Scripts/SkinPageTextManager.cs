using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkinPageTextManager : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update

    public void Skin1Text()
    {
        textMeshPro.text = "우리들의 착한 친구";
    }

    public void Skin2Text()
    {
        textMeshPro.text = "Zㅣ용 Zㅣ용 고글맨";
    }

    public void Skin3Text()
    {
        textMeshPro.text = "라이트닝 썬더~";
    }

    public void Skin4Text()
    {
        textMeshPro.text = "도둑이지만 너무 착하게 생김";
    }

    public void Skin5Text()
    {
        textMeshPro.text = "2ㅁㅎㅁㄴ님 크레이지 모드 천점 달성!";
    }
}

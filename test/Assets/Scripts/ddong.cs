using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddong : MonoBehaviour
{
    // public
    public Sprite sprite;
    public float destroydelay;

    // this object
    GameObject Ddong;    

    // component
    SpriteRenderer spriteRenderer;
    Collider2D col;
    Rigidbody2D rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        Ddong = this.gameObject;
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();  
    }

    //  destroy system
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Player")
        {
            rigid.gravityScale = 0;
            col.enabled = false;
            spriteRenderer.sprite = sprite;
            StartCoroutine("FadeOut");
        }
    }

    IEnumerator FadeOut()
    {   
        for(int i = 10; i >= 0; i--)
        {
            float f = i / 10.0f;
            Color c = spriteRenderer.color;
            c.a = f;
            spriteRenderer.color = c;  
            yield return new WaitForSeconds(destroydelay / 10f);
        }
        Destroy(Ddong);
    }
}

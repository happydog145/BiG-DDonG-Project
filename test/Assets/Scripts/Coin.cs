using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // public 
    public float destroydelay;

    // this object
    GameObject coin; 
    
    // component
    SpriteRenderer spriteRenderer;
    Collider2D col;
    Rigidbody2D rigid;
    AudioSource audioSource;
        
    // Start is called before the first frame update
    void Start()
    {
        coin = this.gameObject;
        audioSource = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();        
    }    

    // destroy system
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Player")
        {
            rigid.gravityScale = 0;
            col.enabled = false;                
            if(collision.gameObject.tag == "Player")
            {
                audioSource.Play();
                Destroy(coin);
            }
            else if (collision.gameObject.tag == "ground")
            {
                StartCoroutine(FadeOut());
            }
        }
    }

    IEnumerator FadeOut()
    {
        for (int i = 10; i >= 0; i--)
        {
            float f = i / 10.0f;
            Color c = spriteRenderer.color;
            c.a = f;
            spriteRenderer.color = c;
            yield return new WaitForSeconds(destroydelay / 10f);
        }
        Destroy(coin);
    }
}

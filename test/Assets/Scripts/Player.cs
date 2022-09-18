using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // this object
    GameObject gameObj;

    // component
    Rigidbody2D rigid;
    
    // public
    public float speed = 10;
    public float jumpPower = 10;

    // jump limit
    public int jumpCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameObj = this.gameObject;
        rigid = GetComponent<Rigidbody2D>();        
    }

    // movement system
    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpCount--;
            rigid.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);          
        }

        if (rigid.position.x > 9)
        {
            rigid.position = new Vector2(-9, rigid.position.y);
        }

        if (rigid.position.x < -9)
        {
            rigid.position = new Vector2(9, rigid.position.y);
        }     
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(x * speed, rigid.velocity.y);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // player destroy system
        if (collision.gameObject.tag == "ddong")
        {
            Destroy(gameObj);
            GameManager.instance.isGameOver = true;
            Debug.Log("게임 종료");
        }

        if (collision.gameObject.tag == "Coin_1")
        {
            Debug.Log("+1 Coin");
            GameManager.instance.coin += 1;
            GameManager.instance.isCoinHit = true;
        }

        if (collision.gameObject.tag == "Coin_10")
        {
            Debug.Log("+10 Coin");
            GameManager.instance.coin += 10;
            GameManager.instance.isCoinHit = true;
        }

        if (collision.gameObject.tag == "Coin_100")
        {
            Debug.Log("+100 Coin");
            GameManager.instance.coin += 100;
            GameManager.instance.isCoinHit = true;
        }

        if (collision.gameObject.tag == "Coin_500")
        {
            Debug.Log("+500 Coin");
            GameManager.instance.coin += 500;
            GameManager.instance.isCoin500Hit = true;
        }

        if (collision.gameObject.tag == "ground")
        {
            jumpCount++;
        }
    }   
}

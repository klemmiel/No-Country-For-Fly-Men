using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public gameManager GM;
    public GameObject glenn;
    //public GameObject bullet;
    public int speed;

    public Rigidbody2D rb;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<gameManager>();
        glenn = GameObject.Find("glenn");
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f); 
    }

    void Update()
    {
        //if (GM.difficulty == 1)
        
       //this.transform.position -= new Vector3(0, speed, 0); 
        
    }

    private void FixedUpdate()
    {



        rb.velocity = -transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "glenn")
        {
            collision.GetComponent<SpriteRenderer>().color = Color.red;
            print("Game Over");
            GM.GameOver();
        }
    }
}

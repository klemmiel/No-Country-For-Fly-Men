using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject glenn;

    public GameObject BulletPrefab;

    public Transform GunPos;

    Rigidbody2D rb;
    Vector2 dir;//direction towards player from enmey
    float timer;
    public gameManager GM;
    float enemySpeed = 2.5f;
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<gameManager>();
        glenn = GameObject.Find("glenn");
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 5f);

        timer = 0;
    }


    void Update()
    {

        if (GM.difficulty == 1)
        {
            timer += Time.deltaTime;

            if (timer > 1)
            {
                Instantiate(BulletPrefab, GunPos.position, GunPos.rotation); //Quaternion.identity <-- 0 0 0 on angle
                timer = 0;
            }

            enemySpeed = 2.5f;
        }

        if (GM.difficulty == 2)
        {
            timer += Time.deltaTime;

            if (timer > 1)
            {
                Instantiate(BulletPrefab, GunPos.position, GunPos.rotation); //Quaternion.identity <-- 0 0 0 on angle
                timer = 0;
            }
            enemySpeed = 3.5f;

        }

    }
    void FixedUpdate()
    {
        dir = glenn.transform.position - transform.position;
        rb.velocity = dir.normalized * enemySpeed;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "glenn")
        {
            collision.GetComponent<SpriteRenderer>().color = Color.red;
            print("Game Over"); 
            GM.GameOver();
        }
    }

}

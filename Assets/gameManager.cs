using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int difficulty = 0;
    public GameObject tryagain;
    public bool gameOver = false;
    public GameObject losescreen;
    public bool losesreen = false;
    void Start()
    {
        tryagain = GameObject.Find("tryagain");
        tryagain.SetActive(false);
        losescreen = GameObject.Find("losescreen");
        losescreen.SetActive(false);
    }
    private void Update()
    {
        if (difficulty == 1)
        {
            print ("level 2");
        }
        if (difficulty == 2)
        {
            print ("level 3"); 
        }
    }

    public void GameOver()
    {
        if (gameOver == false)
        {
            tryagain.SetActive(true);
            losescreen.SetActive(true);
            gameOver = true;
        }
    }

}

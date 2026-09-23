using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public gameManager GM;
    public Text myScore;
    float score = 0;
    float timer;
    private void Start()
    {
    }
    void Update()
    {


        timer += Time.deltaTime;
        if(timer > 5)
        {
            GM.difficulty = Random.Range(0, 3);
            timer = 0;
        }

        if (GM.gameOver == false)
        {
            score += Time.deltaTime * 10;
            myScore.text = "score: " + (int)score;
        }
            

       
    }

}

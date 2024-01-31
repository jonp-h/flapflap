using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D collision)
    {

        FindObjectOfType<GameManager>().score++;
        int score = FindObjectOfType<GameManager>().score;


        FindObjectOfType<UIManager>().scoreText.text = score.ToString();
    }

}

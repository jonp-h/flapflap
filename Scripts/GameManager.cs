using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public void EndGame()
    {
        FindObjectOfType<UIManager>().EndGame();

        PipeMovement[] pipes = FindObjectsOfType<PipeMovement>();

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].pipeSpeed = 0;
        }

        gameHasEnded = true;
    }
}

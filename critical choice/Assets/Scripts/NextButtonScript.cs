using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    public void Playbutton()
    {
        if (finishlin.played == 2)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            Gate.totalScore = 0;
            SceneManager.LoadScene(2);
        }

    }
}


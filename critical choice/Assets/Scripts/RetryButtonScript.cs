using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour
{
    public void Playbutton()
    {
        Gate.totalScore = 0;
        SceneManager.LoadScene(1);
    }
}
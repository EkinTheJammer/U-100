using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class finishlin : MonoBehaviour
{

    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Gate.totalScore >= 6) 
            {
                SceneManager.LoadScene("winscene"); // Puan 6 ila 10 aras�ndaysa "winscene" sahnesine ge�i� yap
            }
            else if (  Gate.totalScore< 6)
            {
                SceneManager.LoadScene("losescene"); // Puan -10 ila 6 aras�ndaysa "losescreen" sahnesine ge�i� yap
            }
        }
    }

}

    

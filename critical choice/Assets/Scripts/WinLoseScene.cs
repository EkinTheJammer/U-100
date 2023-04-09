using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinLoseScene : MonoBehaviour

{
    public int score = 0; // Puan de�eri
    public Text scoreText; // UI �zerindeki puan metni

    public GameObject winScreen; // Win ekran�
    public GameObject loseScreen; // Lose ekran�

    void Update()
    {
        scoreText.text = "Score: " + score.ToString(); // Puan metnini g�ncelle
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {
            if (score >= 6 && score <= 10)
            {
                winScreen.SetActive(true); // Puan de�eri 6 ile 10 aras�nda ise ve FinishLine objesinin collider'�na de�di�inde win ekran�n� aktif et
            }
            else if (score >= -10 && score < 6)
            {
                loseScreen.SetActive(true); // Puan de�eri -10 ile 6 aras�nda ise ve FinishLine objesinin collider'�na de�di�inde lose ekran�n� aktif et
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinLoseScene : MonoBehaviour

{
    public int score = 0; // Puan deðeri
    public Text scoreText; // UI üzerindeki puan metni

    public GameObject winScreen; // Win ekraný
    public GameObject loseScreen; // Lose ekraný

    void Update()
    {
        scoreText.text = "Score: " + score.ToString(); // Puan metnini güncelle
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {
            if (score >= 6 && score <= 10)
            {
                winScreen.SetActive(true); // Puan deðeri 6 ile 10 arasýnda ise ve FinishLine objesinin collider'ýna deðdiðinde win ekranýný aktif et
            }
            else if (score >= -10 && score < 6)
            {
                loseScreen.SetActive(true); // Puan deðeri -10 ile 6 arasýnda ise ve FinishLine objesinin collider'ýna deðdiðinde lose ekranýný aktif et
            }
        }
    }
}

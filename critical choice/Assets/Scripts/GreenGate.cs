using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GreenGate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    public static int totalScore;

    private void Awake()
    {
        _text.text = totalScore.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.CompareTag("Gate"))
        {
            Destroy(collision.gameObject);
            totalScore++;
            _text.text = totalScore.ToString();
        }
    }
}

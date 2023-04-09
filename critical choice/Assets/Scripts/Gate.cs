using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _text;
    public static int totalScore;

    public void Awake()
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

        if (collision.gameObject.CompareTag("GateRED"))
        {
            Destroy(collision.gameObject);
            totalScore--;
            _text.text = totalScore.ToString();
        }
    }
}

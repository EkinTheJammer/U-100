using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _text;
    public static int totalScore;
    private AudioSource _audio;

    public void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _text.text = totalScore.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.CompareTag("Gate"))
        {
            _audio.Play();
            Destroy(collision.gameObject);
            totalScore++;
            _text.text = totalScore.ToString();
        }

        if (collision.gameObject.CompareTag("GateRED"))
        {
            _audio.Play();
            Destroy(collision.gameObject);
            totalScore--;
            _text.text = totalScore.ToString();
        }
    }
}

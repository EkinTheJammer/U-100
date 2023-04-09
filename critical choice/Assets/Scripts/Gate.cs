using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _text;
    public static int totalScore;

    public AudioSource GreenAudio;
    public AudioSource RedAudio;
    public AudioSource BackgroundMusic;

    public void Awake()
    {
        _text.text = "Score: " + totalScore.ToString();
    }
    private void Start()
    {
        BackgroundMusic.Play();
    }

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.CompareTag("Gate"))
        {
            GreenAudio.Play();
            Destroy(collision.gameObject);
            totalScore++;
            _text.text = "Score: " + totalScore.ToString();
        }

        if (collision.gameObject.CompareTag("GateRED"))
        {
            RedAudio.Play();
            Destroy(collision.gameObject);
            totalScore--;
            _text.text = "Score: " + totalScore.ToString();           
        }
    }
}

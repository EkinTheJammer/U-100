using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SameScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text1;
    private Scene _scene;

    
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
        Debug.Log(_scene.name);
    }
    private void Start()
    {
        text1.text = Gate.totalScore.ToString();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_scene.name);
            Gate.totalScore = 0;
            text1.text = Gate.totalScore.ToString();
        }
    }
}


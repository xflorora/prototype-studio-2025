using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Debug = UnityEngine.Debug;

public class CountdownTimer : MonoBehaviour
{

    public float timer;
    public TextMeshProUGUI timerSeconds;
    public ScoreManager scoreManager;
    void Start()
    {
        timerSeconds.text = GetComponent<TextMeshProUGUI>().text;
    }
    
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            //Debug.Log("that's it");
            if (scoreManager.score < 38)
            {
                SceneManager.LoadScene("badEnd");
            }

            if (scoreManager.score >= 38)
            {
                SceneManager.LoadScene("goodEnd");
            }
        }
    }
}

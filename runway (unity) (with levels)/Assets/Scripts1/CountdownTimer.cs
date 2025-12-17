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
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                //Debug.Log("that's it");
                if (scoreManager.score < 20)
                {
                    SceneManager.LoadScene("badEnd");
                }

                if (scoreManager.score >= 20)
                {
                    SceneManager.LoadScene("goodEnd");
                }
            }
            
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                //Debug.Log("that's it");
                if (scoreManager.score < 30)
                {
                    SceneManager.LoadScene("badEnd 1");
                }

                if (scoreManager.score >= 30)
                {
                    SceneManager.LoadScene("goodEnd 1");
                }
            }
            
            if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                //Debug.Log("that's it");
                if (scoreManager.score < 33)
                {
                    SceneManager.LoadScene("badEnd 2");
                }

                if (scoreManager.score >= 33)
                {
                    SceneManager.LoadScene("goodEnd 2");
                }
            }
        }
    }
}

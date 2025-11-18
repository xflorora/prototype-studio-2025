using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    private int antCount;
    private Scene scene;
    private string sceneName;
    private float timer;

    void Start()
    {
        timer = 30f;
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "fire ant")
        {
            timer -= Time.deltaTime;
            /*GameObject[] objects = GameObject.FindGameObjectsWithTag("Ant");
            int antCount = objects.Length;
            Debug.Log("Found object with tag Ant is " +antCount);
            
            if (antCount == 50)
            {
                SceneManager.LoadScene("text 1");
            }*/
            if (timer <= 0)
            {
                SceneManager.LoadScene("text 1");
            }
        }

        if (SceneManager.GetActiveScene().name == "cicada killer")
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene("text 2");
            }
        }

        if (SceneManager.GetActiveScene().name == "spider")
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene("text 3");
            }
        }
    }
}

using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
public class typingNext : MonoBehaviour
{
    public List<GameObject> allThoughts = new List<GameObject>();
    public int thoughtOrder = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject currentThought = allThoughts[thoughtOrder];
            currentThought.SetActive(true);
            /*if (thoughtOrder > 0)
            {
                allThoughts[thoughtOrder-1].SetActive(false);
            }*/
            thoughtOrder++;
            
            if (SceneManager.GetActiveScene().name == "text 0")
            {
                if (thoughtOrder >= 4)
                {
                    SceneManager.LoadScene("fire ant");
                }
            }
            
            if (SceneManager.GetActiveScene().name == "text 1")
            {
                if (thoughtOrder >= 5)
                {
                    SceneManager.LoadScene("cicada killer");
                }
            }
            
            if (SceneManager.GetActiveScene().name == "text 2")
            {
                if (thoughtOrder >= 5)
                {
                    SceneManager.LoadScene("spider");
                }
            }
        }
    }
}
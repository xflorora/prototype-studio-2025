using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;
public class typingNext : MonoBehaviour
{
    public List<GameObject> allThoughts = new List<GameObject>();
    public int thoughtOrder = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject currentThought = allThoughts[thoughtOrder];
            currentThought.SetActive(true);
            if (thoughtOrder > 0)
            {
                allThoughts[thoughtOrder-1].SetActive(false);
            }
            thoughtOrder++;
            if (thoughtOrder >= 6)
            {
                SceneManager.LoadScene("typing");
            }
        }
    }
}

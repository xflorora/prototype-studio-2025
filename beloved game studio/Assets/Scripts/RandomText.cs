using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomText : MonoBehaviour
{
    public List<GameObject> allThoughts = new List<GameObject>();
    public int thoughtOrder = 0;

    public void generateThoughts()
    {
        GameObject currentThought = allThoughts[thoughtOrder];
        currentThought.SetActive(true);
        if (thoughtOrder > 0)
        {
            allThoughts[thoughtOrder-1].SetActive(false);
        }
        thoughtOrder++;
    }
    
    
}

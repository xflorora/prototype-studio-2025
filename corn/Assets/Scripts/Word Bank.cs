using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "kernels.", "are", "there", "as", "children", "as many", "of hundreds", "the mother", "is", "a corncob", "sun", "the", "catch", "to", "direction", "every", "in", "from the stem", 
        "away", "curl", "of leaves", "green ribbons", "rippling", "another", "then", 
        "and", "unfurls", "leaf", "single", "a", "quickly", "water", "on", "takes", 
        "corn seed", "may-moist earth", "in the", "once planted"
    };

    private List<string> workingWords = new List<string>()
    {

    };

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        //Shuffle(workingWords);
        ConverToLower(workingWords);
    }

    /*private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }*/

    private void ConverToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }
        return newWord;
    }
}

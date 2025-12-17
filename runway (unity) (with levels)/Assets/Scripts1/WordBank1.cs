using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WordBank1 : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "haute-couture", "ready-to-wear", "premium-leather", "l'enfant-terrible", "denim", "bumsters", "chiffon",
        "gaga", "knuckleduster", "gucci", "historicism", "skull-scarf", "armadillo-shoes", "kate-moss", 
        "taxi-driver", "low-rise-trouser", "perspex", "nihilism", "corsetier", "dante", "overlook", "coiled",
        "voss", "clamshell", "skulls", "irere", "la-dame-bleue", "bad-romance", "extravagance", "isabella",
        "manta", "plato's-atlantis", "blood-beneath-the-skin", 
    };
    //33 words
    //requirement: 30

    private List<string> workingWords = new List<string>()
    {

    };

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConverToLower(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

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
using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "vivienne", "westwood", "sid vicious", "sex pistols", "punk", "boutique",
        "let it rock", "too fast to live", "too young to die", "seditionaries", 
        "gender", "sleeveless", "mohair", "plaid", "leather", "corset", "textiles", "runway",
        "punkature", "romantic", "mini-crini", "breeches", "bustiers", "paniers", "scarves",
        "leggings", "harris-tweed", "scottish-cloth", "saturn-orb", "polyester",
        "lunafreya nox fleuret", "wedding", "knee-length", "lingering-hope", "amour-ring",
        "pleated", "tartan", "blazers", "anglomania", "victorian", "platforms", "rockinghorse", "heart-shaped-blouse",
        "bondage", "heels",
    };
    //45 words
    //top score: 44

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
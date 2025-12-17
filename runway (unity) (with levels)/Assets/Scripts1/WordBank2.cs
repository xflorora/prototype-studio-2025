using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WordBank2 : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "rei-kawakubo", "distressed", "agendered", "odeur-53", "champaca", "perfume", "concrete", "lumps-and-bumps",
        "persona", "pompidou", "rina-sawayama", "rihanna", "austere", "deconstructed", "asymmetrical", "visionaire",
        "like-the-boys", "demeulemeester", "flower-printed-dress-fabrics", "absence/presence", "antifashion",
        "clothes/not-clothes", "body-meets-dress", "dress-meets-body", "modification", "transgressive", "heart-on-eyes",
        "wonderoud", "floriental", "blackpepper", "wonderwood", "amazingreen", "chlorophyll-gardenia", "marseille",
        "laguna", "hysteria", "serpentine", "yoyogi", "laurel", "palisander", "garage"
    };
    //42 words
    //requirement: 40

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
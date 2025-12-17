using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Typer : MonoBehaviour
{
//our list of images
    public List<GameObject> originalImages = new List<GameObject>();
    public WordBank wordbank = null;
    public TextMeshProUGUI wordOutput = null;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    public int imageOrder = 0;
    
    public ScoreManager scoreManager;
    
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        currentWord = wordbank.GetWord();
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }
    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            
            //runs when word or sentence finishes
            if (IsWordComplete())
            {
                SetCurrentWord();
                GameObject currentImage = originalImages[imageOrder];
                currentImage.SetActive(true);
                /*if (imageOrder > 0)
                {
                    originalImages[imageOrder-1].SetActive(false);
                }*/
                imageOrder++;
                scoreManager.AddScore(1);
            }
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }
    
}

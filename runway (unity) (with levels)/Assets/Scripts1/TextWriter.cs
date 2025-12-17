using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
  private TMP_Text uiTMProText;
  private string textToWrite;
  private int characterIndex;
  private float timePerCharacter;
  private float timer;

  public void AddWriter(TMP_Text uiTMProText, string textToWrite, float timePerCharacter)
  {
    this.uiTMProText = uiTMProText;
    this.textToWrite = textToWrite;
    this.timePerCharacter = timePerCharacter;
    characterIndex = 0;
  }

  private void Update()
  {
    if (uiTMProText != null)
    {
      timer -= Time.deltaTime;
      while (timer <= 0f)
      {
        //display next character
        timer += timePerCharacter;
        characterIndex++;
        uiTMProText.text = textToWrite.Substring(0, characterIndex);

        if (characterIndex >= textToWrite.Length)
        {
          //entire string displayed
          uiTMProText.text = null;
          return;
        }
      }
    }
  }
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public List<string> textList;

    public TMP_Text ShowText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calling the entire list
        int randomIndex = Random.Range(0, textList.Count);
        string randomText = textList[randomIndex];
        
        //each time the scene is loaded, show a random string from the list 
        ShowText.text = randomText;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceController : MonoBehaviour
{

    public int Index;
    public GameObject Icon;
    public SlicedFilledImage Outline;
    public GameObject outlineReveal;
    public bool isSelected = false;
    public GameObject dad;
    
    public void IncreaseFill()
    {
        Outline.fillAmount += 0.05f;
    }

    private void Update()
    {
        if (Outline.fillAmount == 1 && isSelected==false)
        {
            if (Index == 1)
            {
                WasSelected1();
            }
            else if (Index == 2)
            {
                WasSelected2();
            }
            
            isSelected = true;
            outlineReveal.SetActive(true);
        }
        
        
    }

    private void WasSelected1()
    {
        dad.GetComponent<DadController>().Set2.SetActive(true);
        dad.GetComponent<DadController>().Set1.SetActive(false);
    }

    private void WasSelected2()
    {
        dad.GetComponent<DadController>().Set2.SetActive(false);
        dad.GetComponent<DadController>().Set3.SetActive(true);
    }
    
}

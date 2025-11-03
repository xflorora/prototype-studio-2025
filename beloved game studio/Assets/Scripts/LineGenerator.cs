using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineGenerator : MonoBehaviour
{
    public GameObject linePrefab;
    private LineScript activeLine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newLine = Instantiate(linePrefab);
            activeLine = newLine.GetComponent<LineScript>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }
}

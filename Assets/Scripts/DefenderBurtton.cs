using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBurtton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderBurtton>();
        foreach(DefenderBurtton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    [SerializeField]
    private GameObject[] icons;

    public void ButtonPressed()
    {
        Debug.Log("Button is pressed");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    public bool fault = false;
    [SerializeField]
    private GameObject buttonPressed;

    [SerializeField]
    private List<GameObject> inputarray = new List<GameObject>();

    [SerializeField]
    private List<GameObject> correctarray = new List<GameObject>();

    public void ButtonPressed()
    {
        //inputarray.Add(gameObject.GetComponent());
    }
}

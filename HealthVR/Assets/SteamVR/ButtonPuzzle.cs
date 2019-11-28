using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFix;

namespace Valve.VR.InteractionSystem
{
    public class ButtonPuzzle : MonoBehaviour
    {
        //public bool fault = false;

        public UniFixEvent<GameObject> OnButtonPressed = new UniFixEvent<GameObject>();
        public HoverButton hoverButton;
        //public UniFixEvent<GameObject>

        private GameObject buttonPressed;

        public bool gm = false;
        
        [SerializeField]
        private List<GameObject> inputarray = new List<GameObject>();

        [SerializeField]
        private List<GameObject> correctarray = new List<GameObject>();

        private void Start()
        {
            OnButtonPressed.AddListener(ButtonPressed);
        }
        public void ButtonPressed(GameObject ButtonPressed)
        {
            Debug.Log("Button is pressed");
            inputarray.Add(ButtonPressed);
            for (int i = 0; i < inputarray.Count; i++)
            {
                if (inputarray[i] == correctarray[i])
                    gm = true;
                else
                {
                    hoverButton.ButtonsHigh();
                    Debug.Log("Geen idee");
                }
            }
        }
    }
}


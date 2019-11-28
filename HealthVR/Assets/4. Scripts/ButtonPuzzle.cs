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
    
        private GameObject buttonPressed;

        [SerializeField]
        private List<GameObject> Buttons = new List<GameObject>();

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
        }
    }   
}

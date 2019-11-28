//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Drives a linear mapping based on position between 2 positions
//
//=============================================================================

using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;


namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    [RequireComponent(typeof(Interactable))]
    public class HoverButton : MonoBehaviour
    {
        public Transform movingPart;

        public Vector3 localMoveDistance = new Vector3(0, -0.1f, 0);

        [Range(0, 1)]
        public float engageAtPercent = 0.95f;

        [Range(0, 1)]
        public float disengageAtPercent = 0.9f;

        public HandEvent onButtonDown;
        public HandEvent onButtonUp;
        public HandEvent onButtonIsPressed;

        //[SerializeField]
        //private ButtonPuzzle buttonPuzzle;

        public bool engaged = false;
        public bool buttonDown = false;
        public bool buttonUp = false;
        public bool forceDown = false;

        private Vector3 startPosition;
        private Vector3 endPosition;

        private Vector3 handEnteredPosition;

        private bool hovering;

        private Hand lastHoveredHand;

        [SerializeField]
        private Rigidbody rigidbody3D;

        public bool test = true;

        public bool isPressed = false;

        private void Start()
        {
            rigidbody3D = GetComponent<Rigidbody>();
            if (movingPart == null && this.transform.childCount > 0)
                movingPart = this.transform.GetChild(0);

            startPosition = movingPart.localPosition;
            endPosition = startPosition + localMoveDistance;
            handEnteredPosition = endPosition;
        }

        private void HandHoverUpdate(Hand hand)
        {
            if (!isPressed){
            hovering = true;
            lastHoveredHand = hand;

            bool wasEngaged = engaged;

            float currentDistance = Vector3.Distance(movingPart.parent.InverseTransformPoint(hand.transform.position), endPosition);
            float enteredDistance = Vector3.Distance(handEnteredPosition, endPosition);

            if (currentDistance > enteredDistance)
            {
                //Debug.Log("123");
                enteredDistance = currentDistance;
                handEnteredPosition = movingPart.parent.InverseTransformPoint(hand.transform.position);
            }

            float distanceDifference = enteredDistance - currentDistance;

            float lerp = Mathf.InverseLerp(0, localMoveDistance.magnitude, distanceDifference);

            if (lerp > engageAtPercent)
                engaged = true;
            else if (lerp < disengageAtPercent)
                engaged = false;

            movingPart.localPosition = Vector3.Lerp(startPosition, endPosition, lerp);

            InvokeEvents(wasEngaged, engaged);
            }
        }

        private void Update()
        {
            Debug.Log(this.gameObject.transform.localPosition.y);
            if(this.gameObject.transform.localPosition.y <= 0.30f)
            {
                Pushed();
            }

           
            if (test == false)
            {
                isPressed = false;
                this.gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, .25f, gameObject.transform.localPosition.z);
                movingPart.localPosition = startPosition;
                handEnteredPosition = endPosition;

                InvokeEvents(engaged, false);
                engaged = false;
                test = true;
            }
        }
        public void Pushed()
        {
            isPressed = true;
            Debug.Log("Push is running");
            this.gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, -100f, gameObject.transform.localPosition.z);
        }

        private void InvokeEvents(bool wasEngaged, bool isEngaged)
        {
            buttonDown = wasEngaged == false && isEngaged == true;
            buttonUp = wasEngaged == true && isEngaged == false;

            if (buttonDown && onButtonDown != null)
                onButtonDown.Invoke(lastHoveredHand);
            if (buttonUp && onButtonUp != null)
                onButtonUp.Invoke(lastHoveredHand);
            if (isEngaged && onButtonIsPressed != null)
                onButtonIsPressed.Invoke(lastHoveredHand);
        }
    }
}

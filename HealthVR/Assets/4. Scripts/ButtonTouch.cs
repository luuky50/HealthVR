using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{
    private float startPos = 0.57f;
    private float endPos = 1.325f;

    private float duration = 0.5f;

    [SerializeField]
    private GameObject leftHand;
    [SerializeField]
    private GameObject rightHand;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == leftHand|| collision.gameObject == rightHand)
        {
            Debug.Log("Button has been touched");
            LeanTween.move(gameObject, new Vector3(transform.position.x, endPos, transform.position.z), duration);
        }
    }

}

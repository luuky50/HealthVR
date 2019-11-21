using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedMovement : MonoBehaviour
{
    //Its protected from somebody changes instance value
    private float centerMove = -0.288f;
    private float enterDuration = 3;

    private float exitMove = 6.26f;
    private float exitDuration = 3;

    [SerializeField]
    private bool Enter1;

    private void Start()
    {
        if (Enter1)
            Enter();
        else
            Exit();
    }
    private void Enter()
    {
        LeanTween.move(gameObject, new Vector3(centerMove, transform.position.y, transform.position.z), enterDuration).setEase(LeanTweenType.easeInOutExpo);
    }
    private void Exit()
    {
        LeanTween.move(gameObject, new Vector3(exitMove, transform.position.y, transform.position.z), exitDuration).setEase(LeanTweenType.easeInOutExpo).setOnComplete(OnExitComplete);
    }
    private void OnExitComplete()
    {
        gameObject.SetActive(false);
        //Add code when exit animation is completed :') 
    }
}

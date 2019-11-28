using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem
{
    public class Foo : MonoBehaviour
    {
        bool test = false;
        public GameObject obj;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (obj.GetComponent<ButtonPuzzle>().gm && !test)
            {
                test = true;
                foo();

            }
        }

        public void foo()
        {
            GameManager.Instance.onMinigameCompleted?.Invoke();
            test = !test;
        }
    }
}
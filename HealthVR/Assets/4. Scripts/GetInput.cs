using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInput : MonoBehaviour
{
	void Update()
	{
		Debug.Log(Input.GetJoystickNames());
	}
}

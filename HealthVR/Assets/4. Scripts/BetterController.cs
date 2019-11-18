using Valve.VR;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BetterController : MonoBehaviour
{
	[SerializeField] private SteamVR_Input_Sources handType;
	[SerializeField] private SteamVR_Action_Boolean grabAction;

	private void Update()
	{
		if(GetGrab())
		{
			Debug.Log($"{handType} grabbed.");
		}
	}

	private bool GetGrab()
	{
		return grabAction.GetState(handType);
	}
}
using Valve.VR;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pickupable : MonoBehaviour
{
	private bool inDropZone = false;

	[Header("Debug")]
	[SerializeField] private SteamVR_Action_Boolean actionBinding;

	private void OnEnable()
	{
		actionBinding.onStateUp += OnTriggerRelease;
	}

	private void OnTriggerRelease(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
		Debug.Log($"{fromSource}, {fromAction}");
	}
}
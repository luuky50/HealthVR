using UniFix;
using System;
using Valve.VR;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
	public event Action<SteamVR_Input_Sources> OnGrabPinchUp;
	public event Action<SteamVR_Input_Sources> OnGrabPinchDown;

	[SerializeField] private SteamVR_Action_Boolean grabPinchAction;

	private void OnEnable()
	{
		RegisterAllListeners();
	}

	private void OnLeftButtonUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);
	private void OnLeftButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchDown.Invoke(fromSource);
	private void OnRightButtonUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);
	private void OnRightButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);

	private void RegisterAllListeners()
	{
		grabPinchAction.AddOnStateUpListener(OnLeftButtonUp, SteamVR_Input_Sources.LeftHand);
		grabPinchAction.AddOnStateUpListener(OnRightButtonUp, SteamVR_Input_Sources.RightHand);

		grabPinchAction.AddOnStateDownListener(OnLeftButtonDown, SteamVR_Input_Sources.LeftHand);
		grabPinchAction.AddOnStateDownListener(OnRightButtonDown, SteamVR_Input_Sources.RightHand);
	}
}
using UniFix;
using System;
using Valve.VR;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
	public event Action<SteamVR_Input_Sources> OnGrabPinchUp;
	public event Action<SteamVR_Input_Sources> OnGrabPinchDown;
	public event Action<SteamVR_Input_Sources> OnGrabGribUp;
	public event Action<SteamVR_Input_Sources> OnGrabGribDown;

	[SerializeField] private SteamVR_Action_Boolean grabPinchAction;
	//[SerializeField] private SteamVR_Action_Boolean grabGribAction;

	private void OnEnable()
	{
		RegisterAllListeners();
	}

	private void OnLeftPinchUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);
	private void OnLeftPinchDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchDown.Invoke(fromSource);
	private void OnRightPinchUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);
	private void OnRightPinchDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabPinchUp.Invoke(fromSource);

	//private void OnLeftGribUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabGribUp.Invoke(fromSource);
	//private void OnLeftGribDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabGribDown.Invoke(fromSource);
	//private void OnRightGribUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabGribUp.Invoke(fromSource);
	//private void OnRightGribDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) => OnGrabGribUp.Invoke(fromSource);

	private void RegisterAllListeners()
	{
		grabPinchAction.AddOnStateUpListener(OnLeftPinchUp, SteamVR_Input_Sources.LeftHand);
		grabPinchAction.AddOnStateUpListener(OnRightPinchUp, SteamVR_Input_Sources.RightHand);
		//grabGribAction.AddOnStateUpListener(OnLeftGribUp, SteamVR_Input_Sources.LeftHand);
		//grabGribAction.AddOnStateUpListener(OnRightGribUp, SteamVR_Input_Sources.RightHand);

		grabPinchAction.AddOnStateDownListener(OnLeftPinchDown, SteamVR_Input_Sources.LeftHand);
		grabPinchAction.AddOnStateDownListener(OnRightPinchDown, SteamVR_Input_Sources.RightHand);
		//grabGribAction.AddOnStateDownListener(OnLeftGribDown, SteamVR_Input_Sources.LeftHand);
		//grabGribAction.AddOnStateDownListener(OnRightGribDown, SteamVR_Input_Sources.RightHand);
	}
}
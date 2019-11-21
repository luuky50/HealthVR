using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Transform)), RequireComponent(typeof(Interactable))]
public class Pickupable : MonoBehaviour
{
	//TODO: Pickupable needs a type to detect.
	public bool InDropZone { get; set; } = false;
	private DropZone dropZone = null;
	private Interactable interactable = null;
	private bool inHand = false;

	private void OnEnable()
	{
		interactable = GetComponent<Interactable>();

		InputManager.Instance.OnGrabPinchUp += OnGrabPinchUp;
		InputManager.Instance.OnGrabPinchDown += OnGrabPinchDown;
		interactable.onAttachedToHand += OnAttachedToHand;
		interactable.onDetachedFromHand += OnDetachedFromHand;
	}

	private void OnTriggerEnter(Collider other) => dropZone = other.GetComponent<DropZone>();
	private void OnTriggerExit(Collider other) => dropZone = null;

	private void OnGrabPinchUp(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (dropZone == null || !inHand)
		{
			return;
		}

		dropZone.Occupy(this);
	}

	private void OnGrabPinchDown(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (!InDropZone)
		{
			return;
		}

		dropZone.Unoccupy();
	}

	private void OnAttachedToHand(Hand hand) => inHand = true;
	private void OnDetachedFromHand(Hand hand) => inHand = false;
}
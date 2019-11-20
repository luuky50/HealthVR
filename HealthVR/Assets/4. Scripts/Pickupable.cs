using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Transform)), RequireComponent(typeof(Interactable))]
public class Pickupable : MonoBehaviour
{
	//TODO: Pickupable needs a type to detect.
	private DropZone dropZone = null;
	private Transform cachedTransform = null;
	private Interactable interactable = null;
	private bool inHand = false;

	private void OnEnable()
	{
		cachedTransform = GetComponent<Transform>();
		interactable = GetComponent<Interactable>();

		InputManager.Instance.OnGrabPinchUp += OnGrabPinchUp;
		InputManager.Instance.OnGrabPinchDown += OnGrabPinchDown;
		interactable.onAttachedToHand += OnAttachedToHand;
		interactable.onDetachedFromHand += OnDetachedFromHand;
	}

	private void OnDisable()
	{
		InputManager.Instance.OnGrabPinchUp -= OnGrabPinchUp;
		InputManager.Instance.OnGrabPinchDown -= OnGrabPinchDown;
		interactable.onAttachedToHand -= OnAttachedToHand;
		interactable.onDetachedFromHand -= OnDetachedFromHand;
	}

	private void OnTriggerEnter(Collider other) => dropZone = other.GetComponent<DropZone>();
	private void OnTriggerExit(Collider other) => dropZone = other.GetComponent<DropZone>();

	private void OnGrabPinchUp(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (dropZone == null || !inHand)
		{
			return;
		}

		dropZone.Occupy(cachedTransform);
	}

	private void OnGrabPinchDown(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (dropZone == null || !inHand)
		{
			return;
		}

		dropZone.Unoccupy();
	}

	private void OnAttachedToHand(Hand hand) => inHand = true;
	private void OnDetachedFromHand(Hand hand) => inHand = false;
}
using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Transform)), RequireComponent(typeof(Interactable)), RequireComponent(typeof(Rigidbody))]
public class Pickupable : MonoBehaviour
{
	private const float TELEPORT_BACK_TIME = 3.0f;

	public bool InDropZone { get; set; } = false;
	public Rigidbody CachedRigidbody { get; set; } = null;
	private DropZone dropZone = null;
	private Interactable interactable = null;
	private Transform cachedTransform = null;
	private bool inHand = false;
	private Vector3 beginPosition = Vector3.zero;
	private float teleportBackTimer = 0.0f;

	private void OnEnable()
	{
		interactable = GetComponent<Interactable>();
		cachedTransform = GetComponent<Transform>();
		CachedRigidbody = GetComponent<Rigidbody>();

		beginPosition = cachedTransform.position;

		InputManager.Instance.OnGrabPinchUp += OnGrabPinchUp;
		InputManager.Instance.OnGrabPinchDown += OnGrabButtonDown;
		interactable.onAttachedToHand += OnAttachedToHand;
		interactable.onDetachedFromHand += OnDetachedFromHand;
	}

	public void ResetPosition()
	{
		if(inHand)
		{
			return;
		}

		Debug.Log("Resetting position...");
		cachedTransform.position = beginPosition;
		CachedRigidbody.constraints = RigidbodyConstraints.None;
	}

	private void Update()
	{
		if(cachedTransform.position == beginPosition)
		{
			return;
		}

		if (inHand)
		{
			return;
		}

		teleportBackTimer -= Time.deltaTime;

		if(teleportBackTimer > 0)
		{
			return;
		}

		ResetPosition();
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

	private void OnGrabButtonDown(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (!InDropZone)
		{
			return;
		}

		dropZone.Unoccupy();
	}

	private void OnAttachedToHand(Hand hand) => inHand = true;
	private void OnDetachedFromHand(Hand hand)
	{
		inHand = false;
		teleportBackTimer += TELEPORT_BACK_TIME;
	}
}
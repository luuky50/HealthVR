using UniFix;
using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable)), RequireComponent(typeof(Rigidbody))]
public class Pickupable : MonoBehaviourExtra
{
	private const float TELEPORT_BACK_TIME = 3.0f;

	public bool InDropZone { get; set; } = false;
	public Rigidbody CachedRigidbody { get; private set; } = null;

	[SerializeField] private Transform resetPosition;

	private DropZone dropZone = null;
	private Interactable interactable = null;
	private bool inHand = false;
	private Vector3 beginPosition => resetPosition.position;
	private void OnEnable()
	{
		interactable = GetComponentIfInitialized<Interactable>();
		CachedRigidbody = GetComponentIfInitialized<Rigidbody>();

		resetPosition = transform.parent.Find("ResetPosition").transform;

		CachedRigidbody.constraints = RigidbodyConstraints.FreezePosition;

		InputManager.Instance.OnGrabPinchUp += OnGrabPinchUp;
		InputManager.Instance.OnGrabPinchDown += OnGrabButtonDown;
		interactable.onAttachedToHand += OnAttachedToHand;
		interactable.onDetachedFromHand += OnDetachedFromHand;
	}

	public IEnumerator ResetPosition()
	{
		if(InDropZone)
		{
			Debug.Log("In drop zone");
			yield return null;
		}

		if(inHand)
		{
			Debug.Log("In hand");
			yield return null;
		}

		yield return new WaitForSeconds(TELEPORT_BACK_TIME);

		CachedTransform.position = beginPosition;

		CachedRigidbody.velocity = Vector3.zero;
		CachedRigidbody.constraints = RigidbodyConstraints.FreezeAll;

		yield return null;

		CachedRigidbody.constraints = RigidbodyConstraints.None;

		Debug.Log("Position is reset!");
		StopAllCoroutines();
	}

	private void Update()
	{
		if (CachedRigidbody.velocity != Vector3.zero || CachedRigidbody.constraints != RigidbodyConstraints.FreezeAll && !inHand)
		{
			StartCoroutine(ResetPosition());
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		 dropZone = other.GetComponent<DropZone>();
		 Debug.Log($"Entered {other.name}");

		 if(dropZone == null)
		 {
			Debug.LogError("No DropZone found");
		 }
	}
	private void OnTriggerExit(Collider other) => dropZone = null;

	private void OnGrabPinchUp(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		Debug.Log("OnGrabPinchUp");

		if (dropZone == null)
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

		if(InDropZone)
		{
			return;
		}

		CachedRigidbody.constraints = RigidbodyConstraints.None;
	}

	/*private void OnCollisionEnter(Collision collision)
	{
		if(beginPosition == Vector3.zero)
		{
			CachedRigidbody.velocity = Vector3.zero;
			beginPosition = CachedTransform.position;
		}
	}*/
}
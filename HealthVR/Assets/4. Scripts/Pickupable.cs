﻿using UniFix;
using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable)), RequireComponent(typeof(Rigidbody))]
public class Pickupable : MonoBehaviourExtra
{
	private const float TELEPORT_BACK_TIME = 3.0f;

	public bool InDropZone { get; set; } = false;
	public Rigidbody CachedRigidbody { get; private set; } = null;

	private DropZone dropZone = null;
	private Interactable interactable = null;
	private bool inHand = false;
	private Vector3 beginPosition = Vector3.zero;

	
	private void OnEnable()
	{
		interactable = GetComponentIfInitialized<Interactable>();
		CachedRigidbody = GetComponentIfInitialized<Rigidbody>();

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
			yield break;
		}

		if(inHand)
		{
			Debug.Log("In hand");
			yield break;
		}

		yield return new WaitForSeconds(TELEPORT_BACK_TIME);

		CachedTransform.position = beginPosition;

		CachedRigidbody.velocity = Vector3.zero;
		CachedRigidbody.constraints = RigidbodyConstraints.None;

		Debug.Log("Position is reset!");
	}

	private void Update()
	{
		if (CachedRigidbody.velocity.x != 0.0f || CachedRigidbody.velocity.z != 0.0f)
		{
			StartCoroutine(ResetPosition());
		}
	}

	private void OnTriggerEnter(Collider other) => dropZone = other.GetComponent<DropZone>();
	private void OnTriggerExit(Collider other) => dropZone = null;

	private void OnGrabPinchUp(Valve.VR.SteamVR_Input_Sources inputScource)
	{
		if (dropZone == null || !inHand)
		{
			return;
		}

		Debug.Log("OnGrabPinchUp");
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
		Debug.Log("OnDetachedFromHand");
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(beginPosition == Vector3.zero)
		{
			Debug.Log("Setting begin position...");
			CachedRigidbody.velocity = Vector3.zero;
			beginPosition = CachedTransform.position;
		}
	}
}
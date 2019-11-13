using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SnappingReceiver : MonoBehaviour
{

	[SerializeField] private Interactable desiredInteractable;
	[SerializeField] private MeshRenderer meshRenderer;

	private void Start()
	{
		Debug.Log("Code Is in fact being run");
	}

	private void HighLightEnter()
	{
		meshRenderer.enabled = true;
		meshRenderer.material = meshRenderer.materials[0];
		desiredInteractable.onDetachedFromHand += SnapToPlace;
	}

	private void SnapToPlace(Hand hand)
	{
		meshRenderer.material = meshRenderer.materials[1];
		desiredInteractable.gameObject.SetActive(false);
	}

	private void HighLightExit()
	{
		meshRenderer.material = meshRenderer.materials[1];
		meshRenderer.enabled = false;
		desiredInteractable.onDetachedFromHand -= SnapToPlace;
	}


	private void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Interactable>() == desiredInteractable)
		{
			HighLightEnter();
		}
	}


	private void OnTriggerExit(Collider col)
	{
		HighLightExit();
	}

}
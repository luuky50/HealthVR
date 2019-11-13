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
	}


	private void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Interactable>() == desiredInteractable)
		{
			HighLightEnter();
		}
	}

	private void OnTriggerStay(Collider col)
	{
		if(col.GetComponent<Interactable>() == desiredInteractable)
		{
			desiredInteractable.onDetachedFromHand += SnapToPlace;
		}
	}

	private void OnTriggerExit(Collider col)
	{
		HighLightExit();
	}

}
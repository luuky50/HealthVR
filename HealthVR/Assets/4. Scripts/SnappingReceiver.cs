using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SnappingReceiver : MonoBehaviour
{

	[SerializeField] private Interactable desiredInteractable;
	[SerializeField] private MeshRenderer meshRenderer;
	private bool hasHighlighted = false;
	private bool placed = false;
	private void Start()
	{
		Debug.Log("Code Is in fact being run");
	}

	private void HighLightEnter(MeshFilter otherMeshFilter)
	{
		MeshFilter meshFilter = GetComponent<MeshFilter>();
		meshFilter.mesh = otherMeshFilter.mesh;
		meshRenderer.enabled = true;
		meshRenderer.material = meshRenderer.materials[0];
		desiredInteractable.onDetachedFromHand += SnapToPlace;
		hasHighlighted = true;
		
	}

	private void SnapToPlace(Hand hand)
	{
		desiredInteractable.transform.parent = this.transform;
		desiredInteractable.transform.position = Vector3.zero;

	}

	private void HighLightExit()
	{
		if (!placed)
		{
			meshRenderer.enabled = false;
		}
		desiredInteractable.onDetachedFromHand -= SnapToPlace;
		hasHighlighted = false;
	}


	private void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Interactable>() == desiredInteractable)
		{
			Debug.Log("Highlighting");
			HighLightEnter(col.GetComponentInChildren<MeshFilter>());
		}
	}


	private void OnTriggerExit(Collider col)
	{
		if (hasHighlighted)
		{
			HighLightExit();
		}
	}

}
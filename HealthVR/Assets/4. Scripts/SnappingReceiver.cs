using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class SnappingReceiver : MonoBehaviour
{

	[SerializeField] private Interactable desiredInteractable;
	[SerializeField] private MeshRenderer meshRenderer;
	private bool hasHighlighted = false;
	private bool placed = false;

	public UnityEvent OnCorrectPlacement;

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
		hasHighlighted = true;

	}

	private void SnapToPlace(GameObject attachedObject)
	{
		attachedObject.transform.parent = this.transform;
		attachedObject.transform.position = Vector3.zero;
		CheckCorrectPlaced(attachedObject.GetComponent<Interactable>());
	}

	private void HighLightExit()
	{
		if (!placed)
		{
			meshRenderer.enabled = false;
		}
		hasHighlighted = false;
	}


	private void CheckCorrectPlaced(Interactable attachedInteractable)
	{
		if (attachedInteractable == desiredInteractable)
		{
			OnCorrectPlacement.Invoke();
		}
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Interactable>() != null && !placed)
		{
			Debug.Log("Highlighting");
			HighLightEnter(col.GetComponentInChildren<MeshFilter>());
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if(Input.GetKeyUp(KeyCode.Joystick1Button7) || Input.GetKeyUp(KeyCode.Joystick2Button7)){
			if (other.GetComponent<Interactable>() != null) {
				SnapToPlace(other.gameObject);
			}
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
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class DropZone : MonoBehaviour
{
	//TODO: Check for pickup able type.
	public bool IsOccupied { get; private set; }
	private Transform cachedTransform = null;
	private Pickupable occupyingObject = null;

	private void OnEnable()
	{
		cachedTransform = GetComponent<Transform>();
	}

	public void Occupy(Pickupable occupyingObject)
	{
		if (IsOccupied)
		{			
			return;
		}

		Debug.Log($"Ocupping {name}...");
		IsOccupied = true;

		occupyingObject.InDropZone = true;
		occupyingObject.transform.position = cachedTransform.position;
		occupyingObject.GetComponent<Rigidbody>().isKinematic = true;

		this.occupyingObject = occupyingObject;
	}

	public void Unoccupy()
	{
		if (!IsOccupied)
		{
			return;
		}

		Debug.Log($"Unocupping {name}...");
		IsOccupied = false;

		occupyingObject.InDropZone = false;
		occupyingObject.GetComponent<Rigidbody>().isKinematic = false;
	}
}
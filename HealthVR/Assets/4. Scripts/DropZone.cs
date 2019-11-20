using UnityEngine;

[RequireComponent(typeof(Transform))]
public class DropZone : MonoBehaviour
{
	//TODO: Check for pickup able type.
	public bool IsOccupied { get; private set; }
	private Transform cachedTransform = null;

	private void OnEnable()
	{
		cachedTransform = GetComponent<Transform>();
	}

	public void Occupy(Transform dropedObject)
	{
		if (IsOccupied)
		{			
			return;
		}

		IsOccupied = true;
		dropedObject.transform.position = cachedTransform.position;
	}

	public void Unoccupy()
	{
		if (!IsOccupied)
		{
			return;
		}

		IsOccupied = false;
	}
}
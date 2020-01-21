using UniFix;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class DropZone : MonoBehaviourExtra
{
	/*public bool IsOccupied { get; private set; }
	[SerializeField] private Pickupable desiredPickupable;
	private Pickupable occupyingPickupable = null;
		
	public void Occupy(Pickupable occupyingPickupable)
	{
		Debug.Log("Trying to occupy...");

		if (IsOccupied)
		{
			occupyingPickupable.ResetPosition();
			return;
		}

		this.occupyingPickupable = occupyingPickupable;

		IsOccupied = true;

		occupyingPickupable.InDropZone = true;
		occupyingPickupable.CachedTransform.position = CachedTransform.position;
		occupyingPickupable.CachedRigidbody.constraints = RigidbodyConstraints.FreezePosition;
		
		Debug.Log("Occupied!");

		if(!IsRightDroppedObject(occupyingPickupable))
		{
			return;
		}

		GameManager.Instance.onMinigameCompleted?.Invoke();
	}

	public void Unoccupy()
	{
		if (!IsOccupied)
		{
			return;
		}

		IsOccupied = false;

		occupyingPickupable.InDropZone = false;
		occupyingPickupable.CachedRigidbody.constraints = RigidbodyConstraints.None;
	}

	private bool IsRightDroppedObject(Pickupable occupyingPickupable)
	{
		if(occupyingPickupable != desiredPickupable)
		{
			return false;
		}

		return true;
	}*/
}
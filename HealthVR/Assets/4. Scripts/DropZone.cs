using UniFix;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class DropZone : MonoBehaviourExtra
{
	public bool IsOccupied { get; private set; }
	[SerializeField] private Pickupable desiredPickupable;
	private Pickupable occupyingPickupable = null;
		
	public void Occupy(Pickupable occupyingPickupable)
	{
		if (IsOccupied)
		{
			occupyingPickupable.ResetPosition();
			return;
		}

		Debug.Log("Occupying...");

		this.occupyingPickupable = occupyingPickupable;

		IsOccupied = true;

		occupyingPickupable.InDropZone = true;
		occupyingPickupable.CachedTransform.position = CachedTransform.position;
		occupyingPickupable.CachedRigidbody.constraints = RigidbodyConstraints.FreezePosition;

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
	}
}
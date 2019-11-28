using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
	[SerializeField] private List<Pickupable> spawnablePickups = new List<Pickupable>();
	private List<GameObject> instancedpickupables = new List<GameObject>();
	[SerializeField] private List<Transform> spawnLocations = new List<Transform>();
	[SerializeField] private float yObject = 3.0f;

	private void Start()
	{
		GameManager.Instance.onMinigameCompleted.AddListener(RemoveObjects);
		GameManager.Instance.onMinigameCompleted.AddListener(SpawnObjects);
		SpawnObjects();
	}

	public void RemoveObjects()
	{
		int indexMax = instancedpickupables.Count;
		for (int i = 0; i < indexMax; i++)
		{
			Destroy(instancedpickupables[i].gameObject);
		}
	}

	public void SpawnObjects()
	{
		for(int i = 0; i < spawnLocations.Count; i++)
		{
			GameObject newPickupable = Instantiate(spawnablePickups[i].gameObject, spawnLocations[i]);
			newPickupable.transform.position = spawnLocations[i].position;
			instancedpickupables.Add(newPickupable);
			LeanTween.moveLocalY(newPickupable, yObject, 2);
		}

	}
}

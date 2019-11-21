using System.Collections;
using System.Collections.Generic;
using UniFix;
using UnityEngine;

public class BedManager : Singleton<BedManager>
{
	[SerializeField] private List<Bed> beds;
	private Bed currentBedInRoom;
	private Bed nextBed;


	private void OnEnable()
	{
		GameManager.Instance.onMinigameCompleted.AddListener(MoveBeds);
	}

	private void MoveBeds()
	{
		currentBedInRoom.MoveOut();
		nextBed.MoveIn();
		SetBedRotation();
	}

	private void SetBedRotation()
	{
		if ((beds.IndexOf(nextBed) + 1) < beds.Count)
		{
			currentBedInRoom = nextBed;
			nextBed = beds[beds.IndexOf(nextBed) + 1];
		}
		if(beds.IndexOf(currentBedInRoom)  == beds.Count - 1)
		{
			//Game Completed
		}
	}

}

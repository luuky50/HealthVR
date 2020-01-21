using UniFix;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
	public List<Pickupable> Pickupables { get; private set; } = new List<Pickupable>();
	[HideInInspector] public UniFixEvent onMinigameCompleted = new UniFixEvent();
	[HideInInspector] public UniFixEvent onAllMinigamesCompleted = new UniFixEvent();

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnEnable()
	{
		foreach(Pickupable pickupable in FindObjectsOfType<Pickupable>())
		{
			Pickupables.Add(pickupable);
		}

		onMinigameCompleted.AddListener(OnMinigameCompleted);
		onAllMinigamesCompleted.AddListener(OnAllMinigamesCompleted);
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	private void OnMinigameCompleted()
	{
		Debug.Log("Minigame completed!");

		foreach(Pickupable pickupable in Pickupables)
		{
			//pickupable.ResetPosition();
		}
	}

	private void OnAllMinigamesCompleted()
	{
		Debug.Log("All Minigames completed!");
	}
}
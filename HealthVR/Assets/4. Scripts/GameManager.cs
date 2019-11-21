using UniFix;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	[HideInInspector] public UniFixEvent onMinigameCompleted = new UniFixEvent();
	[HideInInspector] public UniFixEvent onAllMinigamesCompleted = new UniFixEvent();

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnEnable()
	{
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
	}

	private void OnAllMinigamesCompleted()
	{
		Debug.Log("All Minigames completed!");
	}
}
using UniFix;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	[HideInInspector] public UniFixEvent onMinigameCompleted;

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnEnable()
	{
		onMinigameCompleted.AddListener(OnMinigameCompleted);
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	private void OnMinigameCompleted()
	{
		Debug.Log("Minigame completed!");
	}
}
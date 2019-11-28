using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniFix;
using System.Linq;

public class GamePlayManager : Singleton<GamePlayManager>
{

	public UniFixEvent OnGameFinished;

	private bool firstSceneSwitch = false;

	public List<Bed> ShuffleBedList(List<Bed> beds)
	{
		List<Bed> shuffledList = beds.OrderBy(x => Random.value).ToList();
		return shuffledList;
	}

	private void OnGameIsFinished()
	{
		SceneManager.LoadScene(2);
	}

	private void Awake()
	{
		DontDestroyOnLoad(this);
		if (!firstSceneSwitch)
			StartCoroutine("TimeTillStartGame");
	}

	private IEnumerator TimeTillStartGame()
	{
		yield return new WaitForSeconds(30);
		SceneManager.LoadScene(1);
	}

}


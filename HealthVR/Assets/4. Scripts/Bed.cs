using UnityEngine;

public class Bed : MonoBehaviour
{

	[SerializeField] private Transform turningPoint;
	[SerializeField] private Transform moveInPoint;
	[SerializeField] private Transform moveOutPoint;

	public void MoveOut()
	{
		LeanTween.move(gameObject, turningPoint.position, 2);
		LeanTween.rotateY(gameObject, 0, 1);
		gameObject.SetActive(false);
	}

	public void MoveIn()
	{
		LeanTween.move(gameObject, turningPoint.position, 2);
		LeanTween.rotateY(gameObject, 90, 1);
	}


}

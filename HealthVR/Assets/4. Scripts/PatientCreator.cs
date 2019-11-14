using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatientCreator : MonoBehaviour
{
	public Patient Patient { get; private set; }
	private string[] maleNames = { "Josh", "Jim", "Dirk"};
	private string[] femaleNames = { "Jenna", "Debby", "Daphne"};

	private void Start()
	{
		CreateNewPatient();
	}

	public void CreateNewPatient()
	{
		GenderType currentGender = (GenderType)Random.Range(0, 2);
		string currentName = string.Empty;

		if(currentGender == GenderType.Male)
		{
			currentName = maleNames[Random.Range(0, maleNames.Length)];
		}
		else
		{
			currentName = femaleNames[Random.Range(0, maleNames.Length)];
		}

		Debug.Log(currentName);
	}
}
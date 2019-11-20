using UniFix;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PatientCreator : Singleton<PatientCreator>
{
	public Patient Patient { get; private set; }
	private string[] maleNames = { "Josh", "Jim", "Dirk" };
	private string[] femaleNames = { "Jenna", "Debby", "Daphne" };

	#region Testing
	private Button button;
	#endregion

	protected override void Awake()
	{
		base.Awake();

		button = GetComponent<Button>();
		button.onClick.AddListener(() => CreateNewPatient());
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	public void CreateNewPatient()
	{
		GenderType currentGender = EnumExtentions<GenderType>.Random;
		string currentName = (currentGender == GenderType.Male) ? maleNames[Random.Range(0, maleNames.Length)] : femaleNames[Random.Range(0, femaleNames.Length)];
		
		EyeColorType currentEyeColor = EnumExtentions<EyeColorType>.Random;
		HairColorType currentHairColor = EnumExtentions<HairColorType>.Random;
		BloodType currentBloodType = EnumExtentions<BloodType>.Random;

		Patient newPatient = new Patient(currentName, currentGender, currentEyeColor, currentHairColor, currentBloodType);
		Patient = newPatient;
	}
}
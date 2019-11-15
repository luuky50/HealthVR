
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatientCreator : MonoBehaviour
{
	public Patient Patient { get; private set; }
	private string[] maleNames = { "Josh", "Jim", "Dirk" };
	private string[] femaleNames = { "Jenna", "Debby", "Daphne" };
		
	public void CreateNewPatient()
	{
		GenderType currentGender = EnumExtentions<GenderType>.GetRandomEnum();
		string currentName = (currentGender == GenderType.Male) ? maleNames[Random.Range(0, maleNames.Length)] : femaleNames[Random.Range(0, femaleNames.Length)];
		
		EyeColorType currentEyeColor = EnumExtentions<EyeColorType>.GetRandomEnum();
		HairColorType currentHairColor = EnumExtentions<HairColorType>.GetRandomEnum();
		BloodType currentBloodType = EnumExtentions<BloodType>.GetRandomEnum();

		Patient newPatient = new Patient(currentName, currentGender, currentEyeColor, currentHairColor, currentBloodType);
		Patient = newPatient;
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient
{
	public string Name { get; private set; }
	public GenderType Gender { get; private set; }
	public EyeColorType EyeColor { get; private set; }
	public HairColorType HairColor { get; private set; }
	public BloodType BloodType { get; private set; }

	public Patient(string name, GenderType gender, EyeColorType eyeColor, HairColorType hairColor, BloodType bloodType)
	{
		Name = name;
		Gender = gender;
		EyeColor = eyeColor;
		HairColor = hairColor;
		BloodType = bloodType;
	}
}
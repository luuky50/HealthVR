using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatientHandler : MonoBehaviour
{
    #region scriptLinks
    public PatientLoader _patientLoader;
    #endregion

    #region varibles
    #region UI
    public Image Patient_Images_UI;
    public Text Patient_Info_Text;
    public Text Patient_Name_Text;
    public Text Patient_Age_Text;
    public Text Patient_BloodType_Text;
    public Text Patient_EyeColor_Text;
    public Text Patient_HairColor_Text;
    public Text Patient_Sex_Text;
    public Text Patient_Disorder_Text;
    #endregion
    public Sprite[] PatientImages;
    #endregion



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeCurrentPatient(0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeCurrentPatient(1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeCurrentPatient(2);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeCurrentPatient(3);
        }

    }

    public void ChangeCurrentPatient(int _patient)
    {
        Patient newPatient;
        newPatient = _patientLoader.Patients[_patient];

        Patient_Images_UI.sprite = PatientImages[newPatient.PhotoID];
        Patient_Info_Text.text = newPatient.PatientInfo.ToString();
        Patient_Name_Text.text = newPatient.Name.ToString();
        Patient_Age_Text.text = newPatient.Age.ToString();
        Patient_BloodType_Text.text = newPatient.BloodType.ToString();

        Patient_EyeColor_Text.text = newPatient.PatientEyeColor.ToString();
        Patient_EyeColor_Text.text = newPatient.PatientHairColor.ToString();
        Patient_Sex_Text.text = newPatient.PatientSex.ToString();
        Patient_Disorder_Text.text = newPatient.PatientDisorder.ToString();
    }
}

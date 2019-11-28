using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

public class PatientLoader : MonoBehaviour
{
    public List<Patient> temp = new List<Patient>();

    public Dictionary<int, Patient> Patients = new Dictionary<int, Patient>();
    void Start()
    {
        XDocument patientsDoc = XDocument.Load(Application.streamingAssetsPath + "/PatientFile.xml");
        LoadFile(patientsDoc);
    }

    void LoadFile(XDocument doc)
    {
        var newPatient = doc.Descendants("Patients").Descendants("Patient").Select(p => new Patient() //linq expression going through the doc, selecting every "block" called DialogueNode
        {

            PatientID = int.Parse(p.Element("PatientID") != null ? p.Element("PatientID").Value : p.Element("PatientID").Value),  //we'll be assigning the element called "PersonID" in the selected block to a new instance of the variable "XML Nodes" , also here a null check
            PatientInfo = p.Element("PatientInfo") != null ? p.Element("PatientInfo").Value : string.Empty, //string
            PhotoID = int.Parse(p.Element("PhotoID") != null ? p.Element("PhotoID").Value : p.Element("PhotoID").Value), //int
            Name = p.Element("Name") != null ? p.Element("Name").Value : string.Empty, //string
            Age = int.Parse(p.Element("Age") != null ? p.Element("Age").Value : p.Element("Age").Value), //int
            BloodType = p.Element("BloodType") != null ? p.Element("BloodType").Value : string.Empty, //string
            PatientEyeColor = p.Element("PatientEyeColor") != null ? p.Element("PatientEyeColor").Value : string.Empty, //string
            PatientHairColor = p.Element("PatientHairColor") != null ? p.Element("PatientHairColor").Value : string.Empty, //string
            PatientSex = p.Element("PatientSex") != null ? p.Element("PatientSex").Value : string.Empty, //string
            PatientDisorder = p.Element("PatientDisorder") != null ? p.Element("PatientDisorder").Value : string.Empty, //string

        }).ToList(); //Our now fully assigned "XML_Nodes" variable will now be added to the (temporary) nodeinlist list
        int i = 0;
        foreach (var item in newPatient)
        {
            Patients.Add(i, item);
            i++;
        }      
    }

}

public class Patient
{
    public int PatientID { get; set; }
    public string PatientInfo { get; set; }
    public int PhotoID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string BloodType { get; set; }

    public string PatientEyeColor { get; set; }
    public string PatientHairColor { get; set; }
    public string PatientSex { get; set; }
    public string PatientDisorder { get; set; }
}
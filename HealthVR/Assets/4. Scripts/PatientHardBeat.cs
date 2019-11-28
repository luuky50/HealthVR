using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatientHardBeat : MonoBehaviour
{
    public float hardBeatPerMinute;
    public bool hardBeat = true;
    public Text hardBeat_Text;
    public int changeHartbeatTimer = 2;
    [SerializeField] float timer;
    public bool normalPatient;
    public Slider hardBeatSlider;


    public void Awake()
    {
        hardBeatPerMinute = Random.Range(60, 100);
    }


    [SerializeField] float timerHeartBeat =  0.5f;
    [SerializeField] float nextHeartBeat = 0.5f;
    public void Update()
    {
        //slider fade duration op heeel laag zetten (0.0000000000001)
        hardBeatSlider.value = hardBeatPerMinute;

        
        
        if (hardBeat == true && normalPatient == true) 
            NormalHardBeat();

        if (hardBeat == true && normalPatient == false)
            HartDeciecePatient();

        if (hardBeat == false)
            NoHardBeat();

        timer += Time.deltaTime;

        if (timer > changeHartbeatTimer)
            ChangeHeartbeatMinimal();
    }
    float nextHeartbeat;
    float currentHeartBeat;
    float t =1;
    void ChangeHeartbeatMinimal()
    {
        timer = 0;
        t = 0;
        nextHeartbeat = Random.Range(hardBeatPerMinute - 5, hardBeatPerMinute + 5);
        currentHeartBeat = hardBeatPerMinute;
    }

    public void NormalHardBeat()
    {
        if (t < 1)
        {
        t += 1.5f * Time.deltaTime;
            hardBeatPerMinute = Mathf.Lerp(currentHeartBeat, nextHeartbeat, t);
        }

        hardBeat_Text.text = hardBeatPerMinute.ToString("F0");

    }

    public void HartDeciecePatient()
    {
        if (t < 1)
        {
            t += 1.5f * Time.deltaTime;
            hardBeatPerMinute = Mathf.Lerp(currentHeartBeat, nextHeartbeat, t);
            Debug.Log(hardBeatPerMinute);
        }

        hardBeat_Text.text = hardBeatPerMinute.ToString("F0");
    }

    public void NoHardBeat()
    {
        hardBeatPerMinute = 0;
    }
}

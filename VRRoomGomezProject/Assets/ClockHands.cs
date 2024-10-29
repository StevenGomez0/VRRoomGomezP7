using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHands : MonoBehaviour
{
    [SerializeField] GameObject hourHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject secondHand;
    // Start is called before the first frame update
    void Start()
    {
        string seconds = DateTime.Now.ToString("ss");
        Debug.Log(seconds);
        InvokeRepeating("ClockUpdate", 0, 1);
    }

    void ClockUpdate()
    {
        float hourAngle = DateTime.Now.Hour * 30;
        float minuteAngle = DateTime.Now.Minute * 6;
        float secondAngle = DateTime.Now.Second * 6;

        hourHand.transform.localRotation = Quaternion.Euler(hourAngle + 90, hourHand.transform.localRotation.y, -90);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteAngle + 90, minuteHand.transform.localRotation.y, -90);
        secondHand.transform.localRotation = Quaternion.Euler(secondAngle + 90, secondHand.transform.localRotation.y, -90);
    }
}

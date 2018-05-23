using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAnimator : MonoBehaviour {
    public Transform hours, minutes, seconds;
    public bool analog;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hours.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegree);
            minutes.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegree);
            seconds.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegree);
        }
        else
        {
            System.DateTime time = System.DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegree);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegree);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegree);
        }
    }

    private float hoursToDegree = 360f / 12f;       // 12小时360°
    private float minutesToDegree = 360f / 60f;     // 60分钟360°
    private float secondsToDegree = 360f / 60f;     // 60秒360°
}

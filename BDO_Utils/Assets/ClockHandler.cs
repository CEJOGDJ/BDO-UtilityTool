using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockHandler : MonoBehaviour {

    // Array containing DateTimes to keep track of
    [HideInInspector] private List<DateTime> m_timers = null;

    // The current DateTime
    [HideInInspector] private DateTime m_currentTime;

    private void Awake()
    {
        m_timers = new List<DateTime>();
    }
	
	// Update is called once per frame
	void Update () {

        // Update the clock
        m_currentTime = DateTime.Now;

        Debug.Log(m_currentTime.ToString("HH:mm:ss"));
        m_currentTime = m_currentTime.AddMinutes(15);
        Debug.Log(m_currentTime.ToString("HH:mm:ss"));
        // Check if an alarm should go off

    }

}

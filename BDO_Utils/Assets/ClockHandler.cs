using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockHandler : MonoBehaviour {

    // Array containing DateTimes to keep track of
    [HideInInspector] private List<DateTime> m_alarms = null;

    // The current DateTime
    [HideInInspector] private DateTime m_currentTime;

    // The seconds before 15 minutes has passed when the alarm should go off (warn the user)
    [HideInInspector] private int m_secondsBeforeWarning = 0;

    // The seconds before an item appears at the marketplace after it was registered
    [HideInInspector] private int m_secondsAfterItemAppear = 15 * 60;

    // Temporary Debug (Displays the clock in console)
    [SerializeField] public bool debugShowTimeConsole = false;

    private void Awake()
    {
        m_alarms = new List<DateTime>();
    }
	
	// Update is called once per frame
	void Update () {

        // Update the clock
        m_currentTime = DateTime.Now;

        // Temporary Debug Section
        if(debugShowTimeConsole)
        {
            Debug.Log(m_currentTime.ToString("HH:mm:ss"));
        }

        // Check if an alarm should go off
        foreach (DateTime time in m_alarms)
        {
            // TODO: Check if an alarm should go off
        }

    }

    /* Makes the alarm go off at a specific given time, for example, 22:10:00.
     * 
     * Input:   (hours): The time in hours
     *          (minutes): The time in minutes
     *          (seconds): The time in seconds
     * Output:  NONE
     */
    public void AddAlarmAtSpecificTime(int hours, int minutes, int seconds)
    {
        DateTime newAlarmTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hours, minutes, seconds);
        m_alarms.Add(newAlarmTime);
    }

    /* Makes the alarm go off after a given time, for example, after 15 minutes.
     * 
     * Input:   (hours): The time in hours
     *          (minutes): The time in minutes
     *          (seconds): The time in seconds
     * Output:  NONE
     */
    public void AddAlarmInAmountOfTime(int hours, int minutes, int seconds)
    {
        // Add a time to track
        DateTime newAlarmTime = m_currentTime;
        newAlarmTime.AddMinutes(hours * 60 + minutes);
        newAlarmTime.AddSeconds(seconds);
        m_alarms.Add(newAlarmTime);
    }

    /* Makes the alarm go off depending on when an item was registered.
     * 
     * Input:   (hours): The time in hours
     *          (minutes): The time in minutes
     *          (seconds): The time in seconds
     * Output:  NONE
     */
    public void AddAlarmItemWasRegistered(int hours, int minutes, int seconds)
    {
        DateTime newAlarmTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hours, minutes, seconds);
        newAlarmTime.AddSeconds(m_secondsAfterItemAppear - m_secondsBeforeWarning);
        m_alarms.Add(newAlarmTime);
    }

    /* Removes an alarm, stopping the tracking of the time
     * 
     * Input:   (index): The index in the list of alarms where the alarm is present 
     * Output:  NONE
     */
     public void RemoveAlarm(int index)
    {
        m_alarms.RemoveAt(index);
    }

    /* Getters and Setters below */
    public DateTime GetCurrentTime() { return m_currentTime; }
    public List<DateTime> GetTrackedAlarms() { return m_alarms; }

    public void SetSecondsBeforeWarning(int secondsBeforeWarning) { m_secondsBeforeWarning = secondsBeforeWarning; }
    public int GetSecondsBeforeWarning() { return m_secondsBeforeWarning; }

    public void SetSecondsAfterItemAppear(int secondsAfterItemAppear) { m_secondsAfterItemAppear = secondsAfterItemAppear; }
    public int GetSecondsAfterItemAppear() { return m_secondsAfterItemAppear; }
}

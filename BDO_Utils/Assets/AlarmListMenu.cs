using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/**********************************************************************************************************************
 * Name:            AlarmListMenu
 * --------------------------------------------------------------------------------------------------------------------
 * Description:     The purpose of this script is to add alarm items.
 * --------------------------------------------------------------------------------------------------------------------
 * Script usage:    1. Attatch this script to the object that contains the list with the alarms that should be filled.
 *                  2. Drag the alarm list that should be filled to the script variable "Alarm List".
 *                  3. Drag the prefab that should be used inside the list to the variable "Alarm List Item Prefab".
 * --------------------------------------------------------------------------------------------------------------------
 * Script deps:     
 * --------------------------------------------------------------------------------------------------------------------
 * General Notes:   1. The Alarm List Item Prefab needs to have some specific name conventions in order to work. See the
 *                      Start() function to find out more.
 * --------------------------------------------------------------------------------------------------------------------
 * TODO:            Empty
 * --------------------------------------------------------------------------------------------------------------------
 * @author:         CEJO_J
 * @version:        1.0
 * @lastChanged:    2018-06-25 (CEJO_J)
 *********************************************************************************************************************/

public class AlarmListMenu : MonoBehaviour {

    // The parent to add a alarm list item to (the alarm list)
    public GameObject alarmList;

    // Prefab for a list alarm list item
    public GameObject alarmListItemPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        // Update all the prefabs with new times etc. Also see if an alarm should go off.

	}
}

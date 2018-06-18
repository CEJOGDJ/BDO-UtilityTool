using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

    /*Method used to quit the program from the main menu*/
	public void QuitProgram()
    {
        //Tempcode to test quit call
        Debug.Log("QUITTING PROGRAM!");
        //End tempcode
        Application.Quit();
    }
}

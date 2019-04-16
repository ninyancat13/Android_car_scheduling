using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //importing Unity's UI object names


public class ButtonPress : MonoBehaviour {
    public Button startButtonPress; //variable called startButtonPress storing a Button GameObject
    
	public void StartButtonPress () {
        Debug.Log("This Button was pressed");
	}

}  //closing ButtonPress Class

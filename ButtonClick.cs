using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Import Unity UI namespace
using UnityEngine.SceneManagement; //Import Unity Scene Management namespace

public class ButtonClick2 : MonoBehaviour
{
    public Button startButtonClick; //create a variable called startButtonClick to store a button
                                    // this variable is assigned in the Inspector (drag a button onto it)
                                    //public image backgroundImageReference;
    public Image backgroundImageReference; //need to drag an image here in Unity Inspector

    void Start()
    {
        //Debug.Log("Start Function");
    }

    void Update()
    {
        //Debug.Log("Update Function");

    }

    public void startButtonClickedOn()
    { //new function/method called startButtonClickedOn
        Debug.Log("The Start Button was pressed");
        SceneManager.LoadScene("Scene3"); //this will load the scene name in quotes
                                          //The extra scenes need to appear in your build settings (drag each scene into the file>build settings>load scenes
                                          //backgroundImageReference.color = new Color(0, 0, 1f);
                                          //backgroundImageReference.enabled = false;
                                          //backgroundImageReference.canvas
    }



} //close ButtonClick class
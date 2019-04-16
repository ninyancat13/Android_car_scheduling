using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //import Unity UI namespace

public class toggle : MonoBehaviour {
    public Toggle toggleReference; //drag in Unity Inspector
    public Text toggleTextReference; //Text for toggle if wanted dynamic

    public void ToggleChanged(bool toggleChecked)
    {
        //This function need to be conected to the toggle OnValueChanged 
        if (toggleChecked)
        {
            //code here for when toggle is checked. 
            toggleTextReference.text = "moo";
        }
        else
        {
            //code here for when toggle is unchecked
            toggleTextReference.text = "oow";
        }
    }
}

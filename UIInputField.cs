using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //import Unity UI Namespaces

public class UIInputField : MonoBehaviour
{
    public Text textReference; //variable to store some text to be changed

    public void OnInputFieldContentChange(string inputText)
    {
        //put any code here to react to Input being changed
        textReference.text = inputText; //send Input directly to other Text
    }

    public void OnInputFieldEnded(string inputText)
    {
        //put any code here to react to an Input being finished
        textReference.text = "Input Complete";
    }
}


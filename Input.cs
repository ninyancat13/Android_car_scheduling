using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //import Unity UI namespace

public class UIAbilities : MonoBehaviour
{
    public Toggle toggleReference; //drag in Unity Inspector
    public GameObject PanelReference; //variable to hold a panel

    public void ToggleChanged(bool toggleChecked)
    {
        if (toggleChecked)
        {
            PanelReference.SetActive(true);
        }
        else
        {
            PanelReference.SetActive(false);
        }
    }
}


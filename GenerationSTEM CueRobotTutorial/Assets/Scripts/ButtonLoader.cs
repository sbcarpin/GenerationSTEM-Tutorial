using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLoader : MonoBehaviour
{
    public GameObject Action;
    public GameObject Control;

    public void ActionButton()
    {
        Control.gameObject.SetActive(false);
        Action.gameObject.SetActive(true);
    }

    public void ControlButton()
    {
        Action.gameObject.SetActive(false);
        Control.gameObject.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public GameObject uiButton1;
    public GameObject uiButton2;
    public GameObject model;
    public Canvas canvas00;

    public void ShowBack() {
        uiButton1.gameObject.SetActive(false);
        uiButton2.gameObject.SetActive(true);
        model.transform.eulerAngles = new Vector3(
            model.transform.eulerAngles.x,
            model.transform.eulerAngles.y + 180,
            model.transform.eulerAngles.z
        );
    }
    public void ShowFront()
    {
        uiButton1.gameObject.SetActive(true);
        uiButton2.gameObject.SetActive(false);
        model.transform.eulerAngles = new Vector3(
            model.transform.eulerAngles.x,
            model.transform.eulerAngles.y - 180,
            model.transform.eulerAngles.z
        );
    }

    public void canvas00Toggle() {
        if (canvas00.gameObject.activeSelf == true)
        {
            canvas00.gameObject.SetActive(false);
        }
        else {
            canvas00.gameObject.SetActive(true);
        }

    }

}

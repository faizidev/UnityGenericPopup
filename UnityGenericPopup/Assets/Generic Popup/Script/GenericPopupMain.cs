//@author Faizi Fazal, faizidev@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GenericPopupMain : MonoBehaviour
{
    //Static
    public static GenericPopupMain instance;

    //Public HideInInspector
    [HideInInspector]
    public List<GameObject> genericPopup = new List<GameObject>();

    //Public
    public GameObject popup;
    public Button popupBtn;

    void Awake()
    {
        if (instance != null)
        {
            GameObject.Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    public void addPopup(string heading, string description, bool isCancelable = true, string[] buttonsName = null, System.Action<int> action = null)
    {
        genericPopup.Add(Instantiate(popup) as GameObject);
        genericPopup[genericPopup.Count - 1].transform.SetParent(GameObject.FindObjectOfType<Canvas>().transform, false);
        genericPopup[genericPopup.Count - 1].GetComponent<GenericPopup>().setButtonsName(popupBtn, buttonsName);
        genericPopup[genericPopup.Count - 1].GetComponent<GenericPopup>().setHeading(heading);
        genericPopup[genericPopup.Count - 1].GetComponent<GenericPopup>().setDescription(description);
        genericPopup[genericPopup.Count - 1].GetComponent<GenericPopup>().setDelegate(action);

        if (!isCancelable)
        {
            genericPopup[genericPopup.Count - 1].GetComponent<GenericPopup>().hideCancelBtn();
        }

        //Popup Tween
        genericPopup[genericPopup.Count - 1].gameObject.transform.localScale = new Vector3(.9f, .9f, .9f);
        LeanTween.scale(genericPopup[genericPopup.Count - 1].gameObject, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);
    }

    public void removePopup()
    {
        Destroy(genericPopup[genericPopup.Count - 1]);
        genericPopup.RemoveAt(genericPopup.Count - 1);
    }
}

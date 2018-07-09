//@author Faizi Fazal, faizidev@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddGenericPopup : MonoBehaviour
{
    public void AddMessagePopup()
    {
        GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable");
    }

    public void Add1ButtonPopup()
    {
        GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable", true, new string[] { "OK" }, callBack);
    }

    public void Add2ButtonPopup()
    {
        GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable", true, new string[] { "OK", "YES" }, callBack);
    }

    public void Add3ButtonPopup()
    {
        GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable", false, new string[] { "OK", "YES", "NEVER" }, callBack);
    }

    void callBack(int btnIndex)
    {
        switch(btnIndex)
        {
            case 0: print("OK"); break;
            case 1: print("YES"); break;
            case 2: print("NEVER"); break;
        }
    }
}

//@author Faizi Fazal, faizidev@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericPopup : MonoBehaviour
{
    //Public
    public GameObject holder;
    public Text headingTxt;
    public Text descriptionTxt;
    public Button cancelBtn;

    //Private
    private Button buttons;
    private System.Action<int> PopupTapAction;

    void Start()
    {
       
    }

    public void setHeading(string getText)
    {
        headingTxt.text = getText;
    }

    public void setDescription(string getText)
    {
        descriptionTxt.text = getText;
    }

    public void hideCancelBtn()
    {
        cancelBtn.gameObject.SetActive(false);
    }

    public void setButtonsName(Button getButtons,string[] getButtonsName)
    { 
        int i;

        if (getButtonsName != null)
        {
            for (i = 0; i < getButtonsName.Length; i++)
            {
                buttons = Instantiate(getButtons) as Button;
                buttons.transform.SetParent(holder.transform, false);
                buttons.GetComponentInChildren<Text>().text = getButtonsName[i];
                int btnIndex = i;
                buttons.onClick.AddListener(() => callBack(btnIndex) );
            }
        }
    }

    public void setDelegate(System.Action<int> action = null)
    {
        PopupTapAction = action;
    }

    private void callBack(int btnIndex)
    {
        if(PopupTapAction!= null)
        { PopupTapAction(btnIndex); }
        
        removePopup();
    }

    public void removePopup()
    {
        Destroy(GenericPopupMain.instance.genericPopup[GenericPopupMain.instance.genericPopup.Count - 1]);
        GenericPopupMain.instance.genericPopup.RemoveAt(GenericPopupMain.instance.genericPopup.Count - 1);
    }
}

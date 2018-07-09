# UnityGenericPopup

Here is Generic Popup for unity games and app by using unity UGUI, very easy to use and reduce development time 
by calling just 1 line of code.

:: HOW TO USE ::
Just add 1st time GenericPopupMain.cs in Main scene of project, and add popup what ever where want but remember Canvas must required :)

>> Here is the example of message popup <<
GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable");


>> Here is the example of popup with 1 button <<
GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable", true, new string[] { "OK" }, callBack);

Note: callBack is Action where you get index of button was clicked

>> Here is the example of popup with 1 button <<
GenericPopupMain.instance.addPopup("Internet Error", "Internet Connention Not Reachable", true, new string[] { "OK", "YES" }, callBack);

Note: callBack is Action where you get index of button was clicked

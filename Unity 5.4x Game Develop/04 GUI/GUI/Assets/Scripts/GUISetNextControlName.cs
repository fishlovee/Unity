using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUISetNextControlName : MonoBehaviour {
    public string login = "username";
    public string login2 = "no action here";
    string pwd = "123";
    void OnGUI()
    {
        GUI.SetNextControlName("user");
        login = GUI.TextField(new Rect(10, 10, 130, 20), login);

        GUI.SetNextControlName("login");
        login2 = GUI.TextField(new Rect(10, 40, 130, 20), login2);
        if (/*Event.current.Equals(Event.KeyboardEvent("return")) &&*/ GUI.GetNameOfFocusedControl() == "user")
            Debug.Log("user");

        if (GUI.Button(new Rect(Screen.width / 10, Screen.height * 2 / 5, Screen.width / 6, Screen.height / 10), "Move Focus"))
            GUI.FocusControl("login");

        if (GUI.Button(new Rect(150, 10, 50, 20), "Login"))
            Debug.Log("Login");

        pwd = GUI.PasswordField(new Rect(200, 200, 200, 100), pwd, '*',25);
    }
}

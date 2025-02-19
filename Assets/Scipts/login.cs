using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.Windows;
using static UnityEditor.ShaderData;

public class login : MonoBehaviour
{
    public TMP_InputField accountnumber;
    public TMP_InputField password;
    public Button loginbutton;
    public UserData userdata;
    ScreenManager screenmanager;
    public Canvas Failed;

    void Start()
    {
        screenmanager = GetComponentInParent<ScreenManager>();
    }

    public void Validate()
    {
        if (accountnumber.text != "" && password.text != "")
        {
            string accno = accountnumber.text;
            string pass = password.text;

            if (accno == userdata.accountNumber && pass == userdata.password)
            {

                Debug.Log("Login Successful!");
                screenmanager.ShowScreen(2);
            }
            else
            {
                Debug.Log("Invalid Account Number or Password");
            }
            accountnumber.text = null;
            password.text = null;
        }
        else
        {
            Popup(Failed);
        }
    }
    void Popup(Canvas canvas)
    {
        StartCoroutine(PopupCR(canvas));
    }
    IEnumerator PopupCR(Canvas canvas)
    {
        canvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        canvas.gameObject.SetActive(false);
    }
}
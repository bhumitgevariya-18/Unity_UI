using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class resetpassword : MonoBehaviour
{
    public UserData userdata;
    public TMP_InputField accno;
    public TMP_InputField newpassword;
    public Canvas Success;
    public Canvas Failed;

    public void ResetPassword()
    {
        if (newpassword.text != "" && accno.text != "")
        {
            if (accno.text == userdata.accountNumber)
            {
                userdata.password = newpassword.text;
                Debug.Log("Password changed Successfully");
                newpassword.text = null;
                Popup(Success);
            }
            else
            {
                Debug.Log("Enter Valid Account Number!!");
                Popup(Failed);
            }
        }
        else
        {
            Debug.Log("Enter Valid Details!!");
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

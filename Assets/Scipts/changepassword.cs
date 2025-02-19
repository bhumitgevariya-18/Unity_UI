using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changepassword : MonoBehaviour
{
    public UserData userdata;
    public TMP_InputField newpassword;
    public Canvas Success;
    public Canvas Failed;

    private void Start()
    {
        Success.gameObject.SetActive(false);
        Failed.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void ChangePassword()
    {
        if (newpassword.text != "")
        {
            userdata.password = newpassword.text;
            Debug.Log("Password changed Successfully");
            Popup(Success);
            newpassword.text = null;
        }
        else
        {
            Debug.Log("Enter New Password");
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
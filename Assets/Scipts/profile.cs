using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class profile : MonoBehaviour
{
    public UserData userData;
    public TMP_Text uname;
    public TMP_Text email;
    public TMP_Text accno;

    void Update()
    {
        uname.text = userData.uname;
        email.text = userData.email;
        accno.text = userData.accountNumber;
    }
}

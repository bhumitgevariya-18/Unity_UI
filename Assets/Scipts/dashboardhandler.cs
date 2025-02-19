using UnityEngine;
using TMPro;
using UnityEditor.UIElements;

public class dashboardhandler : MonoBehaviour
{
    public UserData userData;
    public TMP_Text balance;
    public TMP_Text uname;

    void Update()
    {
        uname.text = userData.uname;
        balance.text = userData.balance.ToString();
    }
}

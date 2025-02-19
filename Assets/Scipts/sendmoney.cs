using UnityEngine;
using TMPro;
using System;
using System.Collections;
using Unity.VisualScripting;


public class sendmoney : MonoBehaviour
{
    public UserData userData;
    public TMP_InputField Reciever;
    public TMP_InputField Amount;
    long a;
    public Canvas Sucess;
    public Canvas Failed;
    public Canvas Pending;
    Canvas tempcanvas;
    bool popupon;

    private void Start()
    {
        Sucess.gameObject.SetActive(false);
        Failed.gameObject.SetActive(false);
        Pending.gameObject.SetActive(false);
    }

    public void SendMoney()
    {
        if (Reciever.text != "" && Amount.text != "")
        {
            a = long.Parse(Amount.text);
            if (a > userData.balance || Reciever.text == userData.accountNumber)
            {
                Debug.Log("Not Enough Money!!!");
                userData.transactions.trdate.Add(DateTime.Now.ToString("dd-MM-yyyy"));
                userData.transactions.toacc.Add(Reciever.text);
                userData.transactions.amounts.Add(Amount.text);
                userData.transactions.status.Add("Failed");
                Popup(Failed);
            }
            else if (a > 100000 && a < userData.balance)
            {
                Debug.Log("Large Amount, So transaction is pending!!!");
                userData.transactions.trdate.Add(DateTime.Now.ToString("dd-MM-yyyy"));
                userData.transactions.toacc.Add(Reciever.text);
                userData.transactions.amounts.Add(Amount.text);
                userData.transactions.status.Add("Pending");
                Popup(Pending);
            }
            else
            {
                userData.balance -= a;
                Debug.Log($"{a} sent to {Reciever.text}");
                userData.transactions.trdate.Add(DateTime.Now.ToString("dd-MM-yyyy"));
                userData.transactions.toacc.Add(Reciever.text);
                userData.transactions.amounts.Add(Amount.text);
                userData.transactions.status.Add("Success");
                Popup(Sucess);
            }
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
        Reciever.text = null;
        Amount.text = null;
    }
}

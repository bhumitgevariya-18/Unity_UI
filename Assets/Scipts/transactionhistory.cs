using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class transactionhistory : MonoBehaviour
{
    public UserData userData;
    public GameObject Entry;
    public GameObject Content;

    private void Start()
    {
        ShowTransactions();
    }
    private void Update()
    {
        //ShowTransactions();
    }

    void ShowTransactions()
    {

        for (int a = 0; a < userData.transactions.toacc.Count; a++)
        {
            GameObject entryinst = Entry;

            entryinst.GetComponentsInChildren<TMP_Text>()[0].text = userData.transactions.trdate[a];
            entryinst.GetComponentsInChildren<TMP_Text>()[1].text = userData.transactions.toacc[a];
            entryinst.GetComponentsInChildren<TMP_Text>()[2].text = userData.transactions.amounts[a];
            entryinst.GetComponentsInChildren<TMP_Text>()[3].text = userData.transactions.status[a];

            if (userData.transactions.status[a] == "Success")
            {
                entryinst.GetComponentsInChildren<TMP_Text>()[3].color = Color.green;
            }
            else if (userData.transactions.status[a] == "Failed")
            {
                entryinst.GetComponentsInChildren<TMP_Text>()[3].color = Color.red;
            }
            else
            {
                entryinst.GetComponentsInChildren<TMP_Text>()[3].color = Color.grey;
            }
            Instantiate(entryinst, Content.transform);
        }
    }
}

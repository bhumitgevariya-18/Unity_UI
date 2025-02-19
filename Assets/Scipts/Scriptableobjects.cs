using System;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

[CreateAssetMenu(fileName = "User Data", menuName = "New User/User Data")]
public class UserData : ScriptableObject
{
    public string accountNumber;
    public string password;
    public long balance = 1000000000000;
    public string uname = "Bruce Wayne";
    public string email = "bruce@batmail.com";
    public Transactions transactions;

    [Serializable]
    public class Transactions
    {
        public List<string> trdate = new List<string>();
        public List<string> toacc = new List<string>();
        public List<string> amounts = new List<string>();
        public List<string> status = new List<string>();
    }

    
}
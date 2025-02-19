using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class debitcard : MonoBehaviour
{
    public UserData userData;
    public Toggle DebitCard;
    public TMP_Text Limit;
    public GameObject card;
    Slider sl;

    void Update()
    {
        card.SetActive(DebitCard.isOn);
        if(DebitCard.isOn)
        { 
            sl = GetComponentInChildren<Slider>();
            float f = sl.value;
            Limit.text = (1000 + 199000 * f).ToString("0");
        }
    }
}

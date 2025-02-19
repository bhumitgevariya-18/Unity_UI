using System.Linq;
using System.Net.Security;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    private CanvasGroup[] screens;

    private void Start()
    {
        screens = GetComponentsInChildren<CanvasGroup>();
        ShowScreen(1);
    }

    public void ShowScreen(int index)
    {
        for (int i = 1; i < screens.Length; i++)
        {
            if (i == index && screens[i])
            {
                screens[i].gameObject.SetActive(true);
            }
            else 
            {
                screens[i].gameObject.SetActive(false);
            }
        }
    }
}

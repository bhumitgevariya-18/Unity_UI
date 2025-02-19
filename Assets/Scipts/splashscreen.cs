using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class splashscreen : MonoBehaviour
{

    CanvasGroup canvas;
    Image img;
    float w, h;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<CanvasGroup>();
        img = GameObject.FindWithTag("SplashLogo").GetComponent<Image>();
        w = img.rectTransform.sizeDelta.x;
        h = img.rectTransform.sizeDelta.y;
    }

    // Update is called once per frame
    void Update()
    {
        w += 5;
        h += 5;
        canvas.alpha -= 0.005f;
        img.rectTransform.sizeDelta = new Vector3(w,h);
        if (canvas.alpha == 0)
        {
            canvas.alpha = 1;
            canvas.gameObject.SetActive(false);
        }
    }

}

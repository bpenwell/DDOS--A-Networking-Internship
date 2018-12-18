using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeAlpha : MonoBehaviour {
    public float fadeInTime;

    private Image fadePanel;
    private Color currentColor = Color.grey;

    void Start ()
    {
        fadePanel = GetComponent<Image>();
    }

    void Update ()
    {
        if(Time.timeSinceLevelLoad < fadeInTime)
        {
            //Fade in
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

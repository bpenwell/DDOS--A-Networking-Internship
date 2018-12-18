using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Transform mybutton;

    // Use this for initialization
    void Start()
    {
        mybutton.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenApplication : MonoBehaviour {

    public GameObject recycleApp;
    public GameObject DefenderApp;
    public GameObject InputApp;

    // Use this for initialization
    void Start () {
        recycleApp.SetActive(false);
        DefenderApp.SetActive(false);
        InputApp.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenRecycle()
    {
        recycleApp.SetActive(true);
    }

    public void OpenDefender()
    {
         DefenderApp.SetActive(true);
    }

    public void OpenInput()
    { 
        InputApp.SetActive(true);
    }

    public void CloseRecycle()
    {
        recycleApp.SetActive(false);
    }

    public void CloseDefender()
    {
        DefenderApp.SetActive(false);
    }

    public void CloseInput()
    {
        InputApp.SetActive(false);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);

    }

    public void QuitRequest()
    {
        Debug.Log("I want to quit!");
        Application.Quit();
    }

    public GameObject selected;
    public void DestroyObject(GameObject g)
    {
        selected = g;
        Destroy(selected);
    }
}
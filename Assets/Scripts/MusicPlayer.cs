using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer Instance = null;
    void Awake () {
        Debug.Log("Music player awake " + GetInstanceID());
        if(Instance != null)
        {
            //Destroy(gameObject);
            print("Destroy extra music player");
        }
        else
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Music player start" + GetInstanceID());

	}
}

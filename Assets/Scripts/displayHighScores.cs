using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayHighScores : MonoBehaviour {

	public Text lvl1;
	public Text lvl2;
	public Text lvl3;

	int temp;
	// Use this for initialization
	void Start()
	{
		lvl1.GetComponent<Text> ().text = Data.lvl1_TopScore.ToString ();
		lvl2.GetComponent<Text> ().text = Data.lvl2_TopScore.ToString ();
		lvl3.GetComponent<Text> ().text = Data.lvl3_TopScore.ToString ();
	}

}

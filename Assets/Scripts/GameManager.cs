using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bullet other;
	public bullet otherNormal;
	public Text userInput;
	float randomNumber;

	//nmap -sT -p 80 192.168.56.101

	int newThrust = 50;
	float newDelay = 2f;

    public void beginGame()
    {
		if (userInput.text.ToString() != bullet.input1 && userInput.text.ToString() != bullet.input2 && userInput.text.ToString() != bullet.input3) {

		}
		else if(userInput.text.ToString() == bullet.input1){
			other.setThrust (50);
			StartCoroutine(Top());
		}
		else if(userInput.text.ToString() == bullet.input2){
			other.setThrust (40);
			StartCoroutine(Top());
		}	   
		else if(userInput.text.ToString() == bullet.input3){
			other.setThrust (30);
			StartCoroutine(Top());
		}	   
    }

	public void endGameCoroutines()
	{
		StopAllCoroutines ();
		//newThrust = 50;
	}


	IEnumerator Top()
	{
		newThrust = 15;
		newDelay = 1f;
		other.setThrust (newThrust);
		for(int i=0; i< 2000; i++)
		{
			randomNumber = Random.Range (1f, 100f);
			//Debug.Log (randomNumber);
			if (randomNumber > 1f && randomNumber <= 15f) {
				other.SpawnTopBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 15f && randomNumber <= 25f) {
				Debug.Log ("normal");
				otherNormal.SpawnTopBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 25f && randomNumber <= 40f) {
				other.SpawnRightBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 40f && randomNumber <= 50f) {
				Debug.Log ("normal");
				otherNormal.SpawnRightBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 50f && randomNumber <= 65f) {
				other.SpawnBottomBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 65f && randomNumber <= 75f) {
				Debug.Log ("normal");
				otherNormal.SpawnBottomBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 75f && randomNumber <= 90f) {
				other.SpawnLeftBullet();
				yield return new WaitForSeconds(newDelay);
			}
			else if (randomNumber > 90f && randomNumber <= 100f) {
				Debug.Log ("normal");
				otherNormal.SpawnLeftBullet();
				yield return new WaitForSeconds(newDelay);
			}

			if (i % 5 == 0 && userInput.text.ToString() == bullet.input1) {
				newThrust += 50;
				Debug.Log ("Increase thrust: " + newThrust);
				other.setThrust (newThrust);
			}
			if (i % 5 == 0 && userInput.text.ToString() == bullet.input2) {
				newThrust += 30;
				Debug.Log ("Increase thrust: " + newThrust);
				other.setThrust (newThrust);
			}
			if (i % 5 == 0 && userInput.text.ToString() == bullet.input3) {
				newThrust += 25;
				Debug.Log ("Increase thrust: " + newThrust);
				other.setThrust (newThrust);
			}

			if (i % 10 == 0) {
				newDelay -= .05f;
				Debug.Log ("Decrease Time: " + newDelay);
			}
		}
	}
}

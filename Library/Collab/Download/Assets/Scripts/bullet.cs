using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour {

    public PaddleMovement yo;
	public GameManager game;

    public GameObject Score;
	public GameObject ScoreText;

    public GameObject TopSpawnLocation;
    public GameObject RightSpawnLocation;
    public GameObject BottomSpawnLocation;
    public GameObject LeftSpawnLocation;

    int ScoreValue;
    float thrust = 100f;

	int level1Goal = 50;
	int level2Goal = 100;
	int level3Goal = 150;

	public static string input1 = "iptables -A INPUT -p tcp --destination-port 80,8080 -j DROP";
	public static string input2 = "sudo apt-get ppmalgorithm";
	public static string input3 = "sudo apt-get NVF_dpmalgorithm";

    public GameObject server;

	GameObject Topclone;
	GameObject Rightclone;
	GameObject Bottomclone;
	GameObject Leftclone;

	GameObject Topclone2;
	GameObject Rightclone2;
	GameObject Bottomclone2;
	GameObject Leftclone2;

	Vector3 UpDownVector = new Vector3 (0, 1, 0);
	Vector3 LeftRightVector = new Vector3 (1, 0, 0);

	//bool increaseSpeed=false;

    // Use this for initialization
    void Start () {
		/*StartCoroutine(turnBoolOn());*/
    }

    void Update()
    {
		

		/*
		if (increaseSpeed == true) {
			Debug.Log ("increasing speed 5");
			thrust += 5;
			increaseSpeed = false;
			StartCoroutine(turnBoolOn());

		}*/
		
		if (Topclone != null){
			Topclone.transform.position -= UpDownVector * thrust * Time.deltaTime;
		}
		if (Rightclone != null){
			Rightclone.transform.position -= LeftRightVector * thrust * Time.deltaTime;
		}
		if (Bottomclone != null){
			Bottomclone.transform.position += UpDownVector * thrust * Time.deltaTime;
		}
		if (Leftclone != null){
			Leftclone.transform.position -= -LeftRightVector * thrust * Time.deltaTime;
		}
		if (Topclone2 != null){
			Topclone2.transform.position -= UpDownVector * thrust * Time.deltaTime;
		}
		if (Rightclone2 != null){
			Rightclone2.transform.position -= LeftRightVector * thrust * Time.deltaTime;
		}
		if (Bottomclone2 != null){
			Bottomclone2.transform.position += UpDownVector * thrust * Time.deltaTime;
		}
		if (Leftclone2 != null){
			Leftclone2.transform.position -= -LeftRightVector * thrust * Time.deltaTime;
		}
    }
    
    public void SpawnTopBullet()
    {
		if (Topclone != null) {
			Topclone2 = Instantiate(TopSpawnLocation, TopSpawnLocation.transform.position, Quaternion.identity);
			Topclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Topclone2.transform.localPosition = new Vector3(200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-90);
			Topclone2.transform.localRotation = spawnRotation;
		}
		else {
			Topclone = Instantiate(TopSpawnLocation, TopSpawnLocation.transform.position, Quaternion.identity);
			Topclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Topclone.transform.localPosition = new Vector3(200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-90);
			Topclone.transform.localRotation = spawnRotation;
		}	

    }
    public void SpawnRightBullet()
    {
		if (Rightclone != null) {
			Rightclone2 = Instantiate(RightSpawnLocation, RightSpawnLocation.transform.position, Quaternion.identity);
			Rightclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Rightclone2.transform.localPosition = new Vector3(0, -290, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-180);
			Rightclone2.transform.localRotation = spawnRotation;
		}
		else {
			Rightclone = Instantiate(RightSpawnLocation, RightSpawnLocation.transform.position, Quaternion.identity);
			Rightclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Rightclone.transform.localPosition = new Vector3(0, -290, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-180);
			Rightclone.transform.localRotation = spawnRotation;
		}
    }
    public void SpawnBottomBullet()
    {
		if (Bottomclone != null) {
			Bottomclone2 = Instantiate(BottomSpawnLocation, BottomSpawnLocation.transform.position, Quaternion.identity);
			Bottomclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Bottomclone2.transform.localPosition = new Vector3(-200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,90);
			Bottomclone2.transform.localRotation = spawnRotation;
		}
		else {
			Bottomclone = Instantiate(BottomSpawnLocation, BottomSpawnLocation.transform.position, Quaternion.identity);
			Bottomclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Bottomclone.transform.localPosition = new Vector3(-200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,90);
			Bottomclone.transform.localRotation = spawnRotation;
		}

    }
    public void SpawnLeftBullet()
    {
		if (Leftclone != null) {
			Leftclone2 = Instantiate(LeftSpawnLocation, LeftSpawnLocation.transform.position, Quaternion.identity);
			Leftclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Leftclone2.transform.localPosition = new Vector3(0, 290, 0);
		}
		else{
			Leftclone = Instantiate(LeftSpawnLocation, LeftSpawnLocation.transform.position, Quaternion.identity);
			Leftclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Leftclone.transform.localPosition = new Vector3(0, 290, 0);
		}
    }

	/*
	//normal traffic
	public void SpawnTopNormalBullet()
	{
		if (Topclone != null) {
			Topclone2 = Instantiate(NormalTopSpawnLocation, NormalTopSpawnLocation.transform.position, Quaternion.identity);
			Topclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Topclone2.transform.localPosition = new Vector3(200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-90);
			Topclone2.transform.localRotation = spawnRotation;
		}
		else {
			Topclone = Instantiate(NormalTopSpawnLocation, NormalTopSpawnLocation.transform.position, Quaternion.identity);
			Topclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Topclone.transform.localPosition = new Vector3(200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-90);
			Topclone.transform.localRotation = spawnRotation;
		}	

	}
	public void SpawnRightNormalBullet()
	{
		if (Rightclone != null) {
			Rightclone2 = Instantiate(NormalRightSpawnLocation, NormalRightSpawnLocation.transform.position, Quaternion.identity);
			Rightclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Rightclone2.transform.localPosition = new Vector3(0, -290, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-180);
			Rightclone2.transform.localRotation = spawnRotation;
		}
		else {
			Rightclone = Instantiate(NormalRightSpawnLocation, NormalRightSpawnLocation.transform.position, Quaternion.identity);
			Rightclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Rightclone.transform.localPosition = new Vector3(0, -290, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,-180);
			Rightclone.transform.localRotation = spawnRotation;
		}
	}
	public void SpawnBottomNormalBullet()
	{
		if (Bottomclone != null) {
			Bottomclone2 = Instantiate(NormalBottomSpawnLocation, NormalBottomSpawnLocation.transform.position, Quaternion.identity);
			Bottomclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Bottomclone2.transform.localPosition = new Vector3(-200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,90);
			Bottomclone2.transform.localRotation = spawnRotation;
		}
		else {
			Bottomclone = Instantiate(NormalBottomSpawnLocation, NormalBottomSpawnLocation.transform.position, Quaternion.identity);
			Bottomclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Bottomclone.transform.localPosition = new Vector3(-200, 0, 0);
			Quaternion spawnRotation = Quaternion.Euler(0,0,90);
			Bottomclone.transform.localRotation = spawnRotation;
		}

	}
	public void SpawnLeftNormalBullet()
	{
		if (Leftclone != null) {
			Leftclone2 = Instantiate(NormalLeftSpawnLocation, NormalLeftSpawnLocation.transform.position, Quaternion.identity);
			Leftclone2.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Leftclone2.transform.localPosition = new Vector3(0, 290, 0);
		}
		else{
			Leftclone = Instantiate(NormalLeftSpawnLocation, NormalLeftSpawnLocation.transform.position, Quaternion.identity);
			Leftclone.transform.SetParent(GameObject.FindGameObjectWithTag("clone").transform, false);
			Leftclone.transform.localPosition = new Vector3(0, 290, 0);
		}
	}
	*/

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
		if (collision.CompareTag("topPaddle"))
        {
            //Debug.Log("top: " + collision.name);
			if(this.name == "TopTrafficSpawn(Clone)"){
				Debug.Log ("TopTrafficSpawn(Clone)");
				Destroy(GameObject.Find("TopTrafficSpawn(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else if (this.name == "TopTrafficSpawn(Clone)(Clone)") {
				Debug.Log ("TopTrafficSpawn(Clone)(Clone)");
				Destroy(GameObject.Find("TopTrafficSpawn(Clone)(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else{
				if (this.name == "RightBulletSpawn(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)(Clone)"));
				}

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue += 5;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}

        }
		if (collision.CompareTag("rightPaddle"))
		{
			//Debug.Log("right: " + collision.name);
			if (this.name == "RightTrafficSpawn(Clone)") {
				Debug.Log ("RightTrafficSpawn(Clone)");
				Destroy(GameObject.Find("RightTrafficSpawn(Clone)(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else if (this.name == "RightTrafficSpawn(Clone)(Clone)") {
				Debug.Log ("RightTrafficSpawn(Clone)(Clone)");
				Destroy(GameObject.Find("RightTrafficSpawn(Clone)(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else {
				
				if (this.name == "RightBulletSpawn(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)(Clone)"));
				}
					
				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue += 5;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}

		}
		if (collision.CompareTag("bottomPaddle"))
		{
			if (this.name == "BottomTrafficSpawn(Clone)") {
				Debug.Log ("BottomTrafficSpawn(Clone)");
				Destroy(GameObject.Find("BottomTrafficSpawn(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else if (this.name == "BottomTrafficSpawn(Clone)(Clone)") {
				Debug.Log ("BottomTrafficSpawn(Clone)(Clone)");
				Destroy (GameObject.Find ("BottomTrafficSpawn(Clone)(Clone)"));

				int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text> ().text = ScoreValue.ToString ();
			}
			else {
				if (this.name == "RightBulletSpawn(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)(Clone)"));
				}

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue += 5;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}

		}
		if (collision.CompareTag("leftPaddle"))
		{
			if (this.name == "LeftTrafficSpawn(Clone)") {
				Debug.Log ("LeftTrafficSpawn(Clone)");
				Destroy(GameObject.Find("LeftTrafficSpawn(Clone)"));

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
			else if (this.name == "LeftTrafficSpawn(Clone)(Clone)") {
				Debug.Log ("LeftTrafficSpawn(Clone)(Clone)");
				Destroy (GameObject.Find ("LeftTrafficSpawn(Clone)(Clone)"));

				int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				ScoreValue -= 2;
				ScoreText.GetComponent<Text> ().text = ScoreValue.ToString ();
			}
			else {

				//Destroy (this);

				if (this.name == "RightBulletSpawn(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("RightBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("LeftBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("BottomBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)(Clone)") {
					Destroy(GameObject.Find("TopBulletSpawn(Clone)(Clone)"));
				}

				int.TryParse(ScoreText.GetComponent<Text>().text, out ScoreValue);
				ScoreValue += 5;
				ScoreText.GetComponent<Text>().text = ScoreValue.ToString();
			}
		}
        if (collision.CompareTag("endMinigame"))
        {
			if (this.name == "LeftBulletSpawn(Clone)" || this.name == "LeftBulletSpawn(Clone)(Clone)" || this.name == "RightBulletSpawn(Clone)" || this.name == "RightBulletSpawn(Clone)(Clone)" ||
			    this.name == "BottomBulletSpawn(Clone)" || this.name == "BottomBulletSpawn(Clone)(Clone)" || this.name == "TopBulletSpawn(Clone)" || this.name == "TopBulletSpawn(Clone)(Clone)") {

				Debug.Log (collision.name);
				/*
				if (this.name == "LeftBulletSpawn(Clone)") {
					Destroy (GameObject.Find ("LeftBulletSpawn(Clone)"));
				}
				if (this.name == "LeftBulletSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("LeftBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)") {
					Destroy (GameObject.Find ("RightBulletSpawn(Clone)"));
				}
				if (this.name == "RightBulletSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("RightBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)") {
					Destroy (GameObject.Find ("BottomBulletSpawn(Clone)"));
				}
				if (this.name == "BottomBulletSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("BottomBulletSpawn(Clone)(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)") {
					Destroy (GameObject.Find ("TopBulletSpawn(Clone)"));
				}
				if (this.name == "TopBulletSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("TopBulletSpawn(Clone)(Clone)"));
				}
				*/
				for (int i = 0; i < 2; i++) {
					Destroy (GameObject.Find ("LeftBulletSpawn(Clone)"));
					Destroy (GameObject.Find ("RightBulletSpawn(Clone)"));
					Destroy (GameObject.Find ("BottomBulletSpawn(Clone)"));
					Destroy (GameObject.Find ("TopBulletSpawn(Clone)"));
					Destroy (GameObject.Find ("LeftBulletSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("RightBulletSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("BottomBulletSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("TopBulletSpawn(Clone)(Clone)"));

					Destroy (GameObject.Find ("LeftTrafficSpawn(Clone)"));
					Destroy (GameObject.Find ("RightTrafficSpawn(Clone)"));
					Destroy (GameObject.Find ("BottomTrafficSpawn(Clone)"));
					Destroy (GameObject.Find ("TopTrafficSpawn(Clone)"));
					Destroy (GameObject.Find ("LeftTrafficSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("RightTrafficSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("BottomTrafficSpawn(Clone)(Clone)"));
					Destroy (GameObject.Find ("TopTrafficSpawn(Clone)(Clone)"));
				}

				int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				if (Data.isGame1Complete == true && game.userInput.text.ToString () == input1) {
					PaddleMovement.wonLastGame1  = true;
				}
				//int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				if (Data.isGame2Complete == true && game.userInput.text.ToString () == input2) {
					PaddleMovement.wonLastGame2 = true;
				}
				//int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				if (Data.isGame3Complete == true && game.userInput.text.ToString () == input3) {
					PaddleMovement.wonLastGame3 = true;
				}
				//if level 1 is done and hit target number
				if (ScoreValue >= level1Goal && game.userInput.text.ToString() == input1) {
					Data.isGame1Complete = true;
					Debug.Log ("Game 1 set to 1");
					if (Data.lvl1_TopScore < ScoreValue) {
						Data.lvl1_TopScore = ScoreValue;
					}
				}
				if (ScoreValue >= level2Goal && game.userInput.text.ToString() == input2) {
					Data.isGame2Complete = true;
					Debug.Log ("Game 2 set to 1");
					if (Data.lvl2_TopScore < ScoreValue) {
						Data.lvl2_TopScore = ScoreValue;
					}
				}
				if (ScoreValue >= level3Goal && game.userInput.text.ToString() == input3) {
					Data.isGame3Complete = true;
					Debug.Log ("Game 3 set to 1");
					if (Data.lvl3_TopScore < ScoreValue) {
						Data.lvl3_TopScore = ScoreValue;
					}
				}

				yo.endGame ();
				game.endGameCoroutines ();

				ScoreValue = 0;
				ScoreText.GetComponent<Text> ().text = ScoreValue.ToString ();
				//audio.Pause();
			}
			else {

				if (this.name == "LeftTrafficSpawn(Clone)") {
					Destroy (GameObject.Find ("LeftTrafficSpawn(Clone)"));
				}
				else if (this.name == "LeftTrafficSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("LeftTrafficSpawn(Clone)(Clone)"));
				}
				else if (this.name == "RightTrafficSpawn(Clone)") {
					Destroy (GameObject.Find ("RightTrafficSpawn(Clone)"));
				}
				else if (this.name == "RightTrafficSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("RightTrafficSpawn(Clone)(Clone)"));
				}
				else if (this.name == "BottomTrafficSpawn(Clone)") {
					Destroy (GameObject.Find ("BottomTrafficSpawn(Clone)"));
				}
				else if (this.name == "BottomTrafficSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("BottomTrafficSpawn(Clone)(Clone)"));
				}
				else if (this.name == "TopTrafficSpawn(Clone)") {
					Destroy (GameObject.Find ("TopTrafficSpawn(Clone)"));
				}
				else if (this.name == "TopTrafficSpawn(Clone)(Clone)") {
					Destroy (GameObject.Find ("TopTrafficSpawn(Clone)(Clone)"));
				}

				//Destroy (this);

				int.TryParse (ScoreText.GetComponent<Text> ().text, out ScoreValue);
				ScoreValue += 5;
				ScoreText.GetComponent<Text> ().text = ScoreValue.ToString ();
			}
            
        }
    }

	public void setThrust(int newThrust)
	{
		thrust = newThrust;
	}
	/*
	IEnumerator turnBoolOn()
	{
		for (int i = 0; i < 4; i++) {
			i++;
			yield return WaitForSeconds(1);
		}
		increaseSpeed = true;

		yield return increaseSpeed;
		;
	}*/

}

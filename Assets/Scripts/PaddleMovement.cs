using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleMovement : MonoBehaviour {

    //only 1 paddle active
    bool[] array;
    bool inGame;
	public GameManager game;
    //start from top paddle, rotate clockwise
	public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject title;
    public GameObject error;
    public GameObject startButton;
    //background elements
    public GameObject border;
    public GameObject TopSpawn;
    public GameObject RightSpawn;
    public GameObject BottomSpawn;
	public GameObject LeftSpawn;
    public GameObject LevelName1;
    public GameObject LevelName2;
    public GameObject LevelName3;
    public GameObject LevelNameMenu;
	public GameObject Score;
	public Text ScoreText;
	public Text userInput;
	public GameObject server;

	public GameObject topbullet;
	public GameObject rightbullet;
	public GameObject bottombullet;
	public GameObject leftbullet;

	public GameObject toptraffic;
	public GameObject righttraffic;
	public GameObject bottomtraffic;
	public GameObject lefttraffic;
	//public GameObject bulletBody;
	//public GameObject bulletPrefab;
    //public GameObject LeftBullet;
    //Rigidbody2D body;

	public GameObject Goal1;
	public GameObject Goal2;
	public GameObject Goal3;

	public GameObject WinGame;
	public GameObject LoseGame;
	public GameObject alreadyWon;
	public GameObject GameRules;

	public AudioSource level1;
	public AudioSource level2;
	public AudioSource level3;

    //public GameObject 

	public float speed;
    int ScoreValue;


	public static bool wonLastGame1 = false;
	public static bool wonLastGame2 = false;
	public static bool wonLastGame3 = false;

    void Start()
    {
        array = new bool[4];
        array[0] = true;
        array[1] = false;
        array[2] = false;
        array[3] = false;
        inGame = false;
        border.SetActive(false);
        TopSpawn.SetActive(false);
        RightSpawn.SetActive(false);
        BottomSpawn.SetActive(false);
        LeftSpawn.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        LevelName1.SetActive(false);
        LevelName2.SetActive(false);
        LevelName3.SetActive(false);
        LevelNameMenu.SetActive(true);
		server.SetActive (true);

        Score.SetActive(false);
		//ScoreText.SetActive(false);

		topbullet.SetActive (false);
		rightbullet.SetActive (false);
		bottombullet.SetActive (false);
		leftbullet.SetActive (false);

		toptraffic.SetActive (false);
		righttraffic.SetActive (false);
		bottomtraffic.SetActive (false);
		lefttraffic.SetActive (false);

		Goal1.SetActive (false);
		Goal2.SetActive (false);
		Goal3.SetActive (false);
		GameRules.SetActive (true);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && inGame)
        {
            p1.SetActive(true);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
        }
        if (Input.GetKey(KeyCode.D) && inGame)
        {
            p1.SetActive(false);
            p2.SetActive(true);
            p3.SetActive(false);
            p4.SetActive(false);
        }
        if (Input.GetKey(KeyCode.A) && inGame)
        {
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(true);
        }
        if (Input.GetKey(KeyCode.S) && inGame)
        {
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(true);
            p4.SetActive(false);
        }        
    }

    public void startGame()
    {
		string u = userInput.text.ToString ();
		//Debug.Log ("user input = " + u);
		if (u != bullet.input1 && u != bullet.input2 && u != bullet.input3) {
			
		}
		if(u == bullet.input1){
			level1.Play ();
			WinGame.SetActive (false);
			LoseGame.SetActive (false);
			alreadyWon.SetActive (false);
			title.SetActive(false);
			error.SetActive(false);
			//controls.SetActive(false);
			inGame = true;
			border.SetActive(true);
			TopSpawn.SetActive(true);
			RightSpawn.SetActive(true);
			BottomSpawn.SetActive(true);
			LeftSpawn.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			startButton.SetActive(false);
			LevelNameMenu.SetActive(false);
			Score.SetActive(true);

			topbullet.SetActive (true);
			rightbullet.SetActive (true);
			bottombullet.SetActive (true);
			leftbullet.SetActive (true);

			toptraffic.SetActive (true);
			righttraffic.SetActive (true);
			bottomtraffic.SetActive (true);
			lefttraffic.SetActive (true);

			LevelName1.SetActive(true);
			Goal1.SetActive (true);
			GameRules.SetActive (false);
		}
		else if(u == bullet.input2){
			level2.Play ();
			WinGame.SetActive (false);
			LoseGame.SetActive (false);
			alreadyWon.SetActive (false);
			title.SetActive(false);
			error.SetActive(false);
			//controls.SetActive(false);
			inGame = true;
			border.SetActive(true);
			TopSpawn.SetActive(true);
			RightSpawn.SetActive(true);
			BottomSpawn.SetActive(true);
			LeftSpawn.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			startButton.SetActive(false);
			LevelNameMenu.SetActive(false);
			Score.SetActive(true);

			topbullet.SetActive (true);
			rightbullet.SetActive (true);
			bottombullet.SetActive (true);
			leftbullet.SetActive (true);

			toptraffic.SetActive (true);
			righttraffic.SetActive (true);
			bottomtraffic.SetActive (true);
			lefttraffic.SetActive (true);

			LevelName2.SetActive(true);
			Goal2.SetActive (true);
			GameRules.SetActive (false);
		}
		else if(u == bullet.input3){
			level3.Play ();
			WinGame.SetActive (false);
			LoseGame.SetActive (false);
			alreadyWon.SetActive (false);
			title.SetActive(false);
			error.SetActive(false);
			//controls.SetActive(false);
			inGame = true;
			border.SetActive(true);
			TopSpawn.SetActive(true);
			RightSpawn.SetActive(true);
			BottomSpawn.SetActive(true);
			LeftSpawn.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			startButton.SetActive(false);
			LevelNameMenu.SetActive(false);
			Score.SetActive(true);

			topbullet.SetActive (true);
			rightbullet.SetActive (true);
			bottombullet.SetActive (true);
			leftbullet.SetActive (true);

			toptraffic.SetActive (true);
			righttraffic.SetActive (true);
			bottomtraffic.SetActive (true);
			lefttraffic.SetActive (true);

			LevelName3.SetActive(true);
			Goal3.SetActive (true);
			GameRules.SetActive (false);
		}
    }

    public void endGame()
    {
		string u = userInput.text.ToString ();
		game.endGameCoroutines();
		if (u == bullet.input1) {
			level1.Stop();
			if (Data.isGame1Complete == true && wonLastGame1 == true) {
				alreadyWon.SetActive (true);
			}
			else if (Data.isGame1Complete == true && wonLastGame1 == false) {
				WinGame.SetActive (true);
			}
			else if (Data.isGame1Complete == false) {
				LoseGame.SetActive (true);
			}

			title.SetActive(true);
			error.SetActive(true);
			//controls.SetActive(true);
			inGame = false;

			border.SetActive(false);
			TopSpawn.SetActive(false);
			RightSpawn.SetActive(false);
			BottomSpawn.SetActive(false);
			LeftSpawn.SetActive(false);

			p1.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);

			startButton.SetActive(true);

			LevelNameMenu.SetActive(true);
			LevelName1.SetActive(false);

			Score.SetActive(false);

			topbullet.SetActive (false);
			rightbullet.SetActive (false);
			bottombullet.SetActive (false);
			leftbullet.SetActive (false);

			toptraffic.SetActive (false);
			righttraffic.SetActive (false);
			bottomtraffic.SetActive (false);
			lefttraffic.SetActive (false);

			Goal1.SetActive (false);
		}
		else if (u == bullet.input2) {
			level2.Stop();
			if (Data.isGame2Complete == true && wonLastGame2 == true) {
				alreadyWon.SetActive (true);
			}
			else if (Data.isGame2Complete == true && wonLastGame2 == false) {
				WinGame.SetActive (true);
			}
			else if (Data.isGame2Complete == false) {
				LoseGame.SetActive (true);
			}

			title.SetActive(true);
			error.SetActive(true);
			//controls.SetActive(true);
			inGame = false;

			border.SetActive(false);
			TopSpawn.SetActive(false);
			RightSpawn.SetActive(false);
			BottomSpawn.SetActive(false);
			LeftSpawn.SetActive(false);

			p1.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);

			startButton.SetActive(true);

			LevelNameMenu.SetActive(true);
			LevelName2.SetActive(false);

			Score.SetActive(false);

			topbullet.SetActive (false);
			rightbullet.SetActive (false);
			bottombullet.SetActive (false);
			leftbullet.SetActive (false);

			toptraffic.SetActive (false);
			righttraffic.SetActive (false);
			bottomtraffic.SetActive (false);
			lefttraffic.SetActive (false);

			Goal2.SetActive (false);
		}
		else if (u == bullet.input3) {
			level3.Stop ();
			if (Data.isGame3Complete == true && wonLastGame3 == true) {
				alreadyWon.SetActive (true);
			}
			else if (Data.isGame3Complete == true && wonLastGame3 == false) {
				WinGame.SetActive (true);
			}
			else if (Data.isGame3Complete == false) {
				LoseGame.SetActive (true);
			}

			title.SetActive(true);
			error.SetActive(true);
			//`controls.SetActive(true);
			inGame = false;

			border.SetActive(false);
			TopSpawn.SetActive(false);
			RightSpawn.SetActive(false);
			BottomSpawn.SetActive(false);
			LeftSpawn.SetActive(false);

			p1.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);

			startButton.SetActive(true);

			LevelNameMenu.SetActive(true);
			LevelName3.SetActive(false);

			Score.SetActive(false);

			topbullet.SetActive (false);
			rightbullet.SetActive (false);
			bottombullet.SetActive (false);
			leftbullet.SetActive (false);

			toptraffic.SetActive (false);
			righttraffic.SetActive (false);
			bottomtraffic.SetActive (false);
			lefttraffic.SetActive (false);

			Goal3.SetActive (false);

		}
    }

    public void enableAll()
    {
        p1.SetActive(true);
        p2.SetActive(true);
        p3.SetActive(true);
        p4.SetActive(true);
    }

    public void disableAll()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
    }
}

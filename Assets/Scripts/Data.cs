using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

    public static bool intro = false;
    public static bool exitComputer = false;
    public static bool warningMessage = false;
    public static bool checkWithManager = false;
    public static bool checkComputer = false;
    public static bool checkInternComputer = false;
    public static bool gameComplete = false;
    public static int conversationCount = 0;
    public static int professor = 0;
    public static int head = 1;
    public static int[] conversationIndex = new int[2];
	public static Vector2 characterPosition;

	public static bool isGame1Complete = false;
	public static bool isGame2Complete = false;
	public static bool isGame3Complete = false;

	public static int lvl1_TopScore = 0;
	public static int lvl2_TopScore = 0;
	public static int lvl3_TopScore = 0;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour {

    public Text userInput;
    public string nmapCommand = "nmap -sT -p 80 192.168.56.101/24";

    public void CheckTerminal()
    {
        string input = userInput.text.ToString();
        if (input == nmapCommand)
        {
            userInput.text = "test";
        }
    }
}

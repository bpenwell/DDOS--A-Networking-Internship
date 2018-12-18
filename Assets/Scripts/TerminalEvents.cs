using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalEvents : MonoBehaviour {

    public Text userInput;
    public Text warningMessage; 
    public string nmapCommand = "nmap -sT -p 80 192.168.56.0/24";

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            CheckTerminal();
        }
    }

    public void CheckTerminal()
    {
        string input = userInput.text.ToString();
        if (input == nmapCommand)
        {
            warningMessage.text = "WARNING: IP SUBNET 192.168.56.0/24 HAS PORT 80 AND 8080 OPEN! PLEASE CONTACT" +
                " YOUR NETWORK ENGINEER";
            Data.warningMessage = true;
        }
        else
        {
            warningMessage.text = "Command not recognized.";
        }
    }

}

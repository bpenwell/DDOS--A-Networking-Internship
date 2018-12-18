using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

    public bool introDialogue = true;

    public string name;

    [TextArea(4, 12)]

    public string[] sentences;

    [TextArea(4, 12)]

    public string[] sentences2;

    [TextArea(4, 12)]

    public string[] sentences3;

    [TextArea(4, 12)]

    public string[] sentences4;

    [TextArea(4, 12)]

    public string[] sentences5;

    [TextArea(4, 12)]

    public string[] sentences6;
}

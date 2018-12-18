using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        if(Data.conversationIndex[Data.conversationCount] == 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences);
        }
        if (Data.conversationIndex[Data.conversationCount] == 1)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences2);
        }
        if (Data.conversationIndex[Data.conversationCount] == 2)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences3);
        }
        if (Data.conversationIndex[Data.conversationCount] == 3)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences4);
        }
        if (Data.conversationIndex[Data.conversationCount] == 4)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences5);
        }
        if (Data.conversationIndex[Data.conversationCount] == 5)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences6);
        }
    }
}

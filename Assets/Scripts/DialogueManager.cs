using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;
	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}
    
    public void DialogueCalls(Dialogue dialogue, movement test)
    {
        if(Data.conversationIndex[Data.conversationCount] == 0)
        {
            StartDialogue(dialogue, dialogue.sentences);
        }
        else if(Data.conversationIndex[Data.conversationCount] == 1)
        {
            StartDialogue(dialogue, dialogue.sentences2);
        }
        else if(Data.conversationIndex[Data.conversationCount] == 2)
        {
            StartDialogue(dialogue, dialogue.sentences3);
        }
        else if (Data.conversationIndex[Data.conversationCount] == 3)
        {
            StartDialogue(dialogue, dialogue.sentences4);
        }
        else if (Data.conversationIndex[Data.conversationCount] == 4)
        {
            StartDialogue(dialogue, dialogue.sentences5);
        }
        else if (Data.conversationIndex[Data.conversationCount] == 5)
        {
            StartDialogue(dialogue, dialogue.sentences6);
        }
    }

    public void StartDialogue(Dialogue dialogue, string[] display)
    {
        animator.SetBool("isOpen", true);
        Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name + " :";

        sentences.Clear();

        foreach (string sentence in display)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            movement.npcEngaged = false;
            Data.conversationIndex[Data.conversationCount]++;
            if (Data.conversationIndex[Data.conversationCount] == 1)
            {
                Data.intro = true;
            }
            if (Data.conversationIndex[Data.professor] == 1)
            {
                Data.conversationIndex[Data.professor]++;
            }
            if (Data.conversationIndex[Data.head] == 2)
            {
                Data.checkInternComputer = true;
            }
            if(Data.conversationIndex[Data.head] == 3)
            {
                Data.checkWithManager = true;
            }
            if(Data.conversationIndex[Data.professor] == 3)
            {
                Data.checkComputer = true;
            }
            if(Data.conversationIndex[Data.professor] == 6)
            {
                Data.gameComplete = true;
            }
            return;
        }
        
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("End of conversation.");
    }

}

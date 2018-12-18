using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    DialogueTrigger script;
    DialogueTrigger script2;
    Dialogue dialogue;
    Dialogue dialogue2;
    public static bool npcEngaged = false;
    public GameObject over = null;
    public GameObject player;

    Rigidbody2D body;
    Animator anim;
    
    // Use this for initialization
    void Start () {
        //playerTransform = GameObject.FindWithTag("Character").transform;
        //profTransform = GameObject.FindWithTag("profTransform").transform;
        if (Data.exitComputer)
        {
            body = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            body.position = Data.characterPosition;
            Data.exitComputer = false;
        }
        else
        {
            foreach (int index in Data.conversationIndex)
            {
                Data.conversationIndex[index] = 0;
            }
            body = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
        }
    }
	
	// Update is called once per frame
	void Update () {

        anim.SetInteger("State", 0);

        if (!npcEngaged)
        {
            if(Data.gameComplete)
            {
                FindObjectOfType<LevelManager>().LoadLevel("Win");
            }

            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                anim.SetInteger("State", 1);
                if (body.velocity.x < 1000f)
                {
                    body.AddForce(Vector2.right * 50000f * Time.deltaTime);

                }
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                anim.SetInteger("State", 2);
                if (body.velocity.x > -1000f)
                {
                    body.AddForce(Vector2.left * 50000f * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.E) && over)
            {
                Debug.Log(over.name);
                if (over.name == "Ben")
                {
                    npcEngaged = true;
                    script = over.GetComponent<DialogueTrigger>();
                    dialogue = script.dialogue;
                    Data.conversationCount = Data.professor;
                    if (Data.conversationIndex[Data.conversationCount] == 0)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 1)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences2);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 2 && Data.checkWithManager)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences3);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 3 && Data.isGame1Complete)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences4);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 4 && Data.isGame2Complete)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences5);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 5 && Data.isGame3Complete)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences6);
                    }
                    else
                    {
                        npcEngaged = false;
                    }
                }
                if (over.name == "Computer" && Data.checkComputer)
                {
                    Debug.Log("Loading level");
                    Data.characterPosition = body.position;
                    Debug.Log(Data.characterPosition);
                    Data.exitComputer = true;
                    FindObjectOfType<LevelManager>().LoadLevel("Computer");
                    npcEngaged = false;
                }
                if (over.name == "Intern_Computer" && Data.checkInternComputer)
                {
                    Debug.Log("Loading level");
                    Data.characterPosition = body.position;
                    Debug.Log(Data.characterPosition);
                    Data.exitComputer = true;
                    FindObjectOfType<LevelManager>().LoadLevel("Intern_Computer");
                    npcEngaged = false;
                }
                if (over.name == "Brian" && Data.intro)
                {
                    npcEngaged = true;
                    script = over.GetComponent<DialogueTrigger>();
                    dialogue = script.dialogue;
                    Data.conversationCount = Data.head;
                    if (Data.conversationIndex[Data.conversationCount] == 0)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 1)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences2);
                    }
                    else if (Data.conversationIndex[Data.conversationCount] == 2 && Data.warningMessage)
                    {
                        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, dialogue.sentences3);
                    }
                    else
                    {
                        npcEngaged = false;
                    }
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("interactObject"))
        {
            over = collision.gameObject;
        }
        if(collision.CompareTag("computerObject"))
        {
            over = collision.gameObject;
        }
  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("interactObject"))
        {
            if (collision.gameObject == over)
            {
                over = null;
            }
        }
        if (collision.CompareTag("computerObject"))
        {
            if (collision.gameObject == over)
            {
                over = null;
            }
        }
    }


}
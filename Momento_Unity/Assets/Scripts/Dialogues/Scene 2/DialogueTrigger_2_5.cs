using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_2_5 : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool MovePanda;
    [HideInInspector]
    public bool TriggeredPanda;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & TriggeredPanda == false)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        //dialogue = FindObjectOfType<EventSystem>().GetDialogue();
        //FindObjectOfType<DialogueManager_2>().SwitchScene = true;
        FindObjectOfType<DialogueManager_2>().StartDialogue(dialogue);
        TriggeredPanda = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-4.9f, 1.1f);
        position = gameObject.transform.position;
        MovePanda = false;
        TriggeredPanda = false;

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MovePanda == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }
    }
}

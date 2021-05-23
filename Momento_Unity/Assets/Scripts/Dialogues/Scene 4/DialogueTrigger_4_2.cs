using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_4_2 : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool TriggeredMom;
    [HideInInspector]
    public bool MoveMom;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;

    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player" & TriggeredMom == true)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        FindObjectOfType<DialogueManager_4>().SwitchScene = true;
        FindObjectOfType<DialogueManager_4>().StartDialogue(dialogue);
    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-33.9f, 18f);
        position = gameObject.transform.position;
        TriggeredMom = false;
        MoveMom = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MoveMom == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_2_2 : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool MoveIsabelle;
    [HideInInspector]
    public bool TriggeredIsabelle;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;

    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & TriggeredIsabelle == false)
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
        TriggeredIsabelle = true;
    }



    void Start()
    {
        target = new Vector2(0.5f, 13.7f);
        position = gameObject.transform.position;
        MoveIsabelle = false;
        TriggeredIsabelle = false;

    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MoveIsabelle == true){
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }

    
    }

}

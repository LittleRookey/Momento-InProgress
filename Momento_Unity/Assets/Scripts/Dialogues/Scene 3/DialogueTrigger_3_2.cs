using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_3_1 : MonoBehaviour
{
    public Dialogue dialogue;
    
    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & FindObjectOfType<DialogueManager_3>().SwitchScene == false)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        //dialogue = FindObjectOfType<EventSystem>().GetDialogue();
        //FindObjectOfType<DialogueManager_2>().SwitchScene = true;
        FindObjectOfType<DialogueManager_3>().StartDialogue(dialogue);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

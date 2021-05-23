using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_3_3 : MonoBehaviour
{
    public Dialogue dialogue;
    
    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & FindObjectOfType<DialogueManager_3>().SwitchScene == true)
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        FindObjectOfType<DialogueManager_3>().SwitchScene = true;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_5_2 : MonoBehaviour
{
    public Dialogue dialogue;
    
    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        
        Debug.Log("Collided");
        if(col.gameObject.name == "Player" & FindObjectOfType<DialogueManager_5>().ChooseEnding == true)
        {
            TriggerDialogue();
            FindObjectOfType<DialogueManager_5>().Ending = 1;
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        FindObjectOfType<DialogueManager_5>().StartDialogue(dialogue);
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

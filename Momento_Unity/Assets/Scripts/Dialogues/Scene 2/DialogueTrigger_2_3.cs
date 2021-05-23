using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_2_3 : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool MoveKidSam;
    [HideInInspector]
    public bool TriggeredKidSam;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & TriggeredKidSam == false)
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
        TriggeredKidSam = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-6.5f, 12.5f);
        position = gameObject.transform.position;
        MoveKidSam = false;
        TriggeredKidSam = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MoveKidSam == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }

    }
}

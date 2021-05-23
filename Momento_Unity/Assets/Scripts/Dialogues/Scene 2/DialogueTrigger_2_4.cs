using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger_2_4 : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool MoveKidAndrew;
    public bool TriggeredKidAndrew;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;

    //StartDialogue();

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player" & TriggeredKidAndrew == false)
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
        TriggeredKidAndrew = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-3f, 12.5f);
        position = gameObject.transform.position;
        MoveKidAndrew = false;
        TriggeredKidAndrew = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MoveKidAndrew == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }
    }
}

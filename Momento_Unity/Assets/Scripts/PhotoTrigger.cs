using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [HideInInspector]
    public bool MovePlayer;
    [HideInInspector]
    public bool TriggeredPhoto;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" & FindObjectOfType<DialogueTrigger_2_3>().TriggeredKidSam == true & FindObjectOfType<DialogueTrigger_2_2>().TriggeredIsabelle == true & FindObjectOfType<DialogueTrigger_2_5>().TriggeredPanda == true & FindObjectOfType<DialogueTrigger_2_4>().TriggeredKidAndrew == true)
        {
            TriggerDialogue();
            TriggeredPhoto = true;
            MovePlayer = true;
            //GameObject varGameObject = GameObject.Find("Player");
            //varGameObject.GetComponent<PlayerMovement>().enabled = false;
        }
    }

    public void TriggerDialogue()
    {
        //Put event system 
        //dialogue = FindObjectOfType<EventSystem>().GetDialogue();
        //FindObjectOfType<DialogueManager_2>().SwitchScene = true;
        FindObjectOfType<DialogueManager_2>().StartDialogue(dialogue);
        FindObjectOfType<DialogueManager_2>().SwitchScene = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-10.3f, 13.5f);
        //position = gameObject.transform.position;
        MovePlayer = false;
        TriggeredPhoto = false;
       

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (MovePlayer == true)
        {
            Player.transform.position = Vector2.MoveTowards(Player.transform.position, target, step);

        }
    }
}

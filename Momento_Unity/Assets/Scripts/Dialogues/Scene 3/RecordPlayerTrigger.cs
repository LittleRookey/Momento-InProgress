using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordPlayerTrigger : MonoBehaviour
{

    public AudioSource Background;
    public AudioSource Rock;
    public AudioSource Pop;
    public AudioSource Jazz;
    public GameObject Notice;
    public Text NoticeText;
    public bool TriggeredRecordPlayer;
    public List<string> Items;
    public Queue<string> items;
    private Queue<string> sentences;
    private string CurrentItem;
    private bool Next;

    private void Start()
    {
        sentences = new Queue<string>();
        items = new Queue<string>();
        TriggeredRecordPlayer = false;

        AudioSource[] audioSources = GetComponents<AudioSource>();
        Rock = audioSources[0];
        Pop = audioSources[1];
        Jazz = audioSources[2];
        Background = GameObject.Find("PartyPlace").GetComponent<AudioSource>();


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("You collided with " + col.gameObject.name);
        if (col.gameObject.name == "Player")
        {

            Items = FindObjectOfType<ItemManager>().Items;
            TriggeredRecordPlayer = true;
            foreach (string item in Items)
            {
                
                string sentence = "Play " + item + "? (Y/N)";
                sentences.Enqueue(sentence);
                items.Enqueue(item);

            }

            DisplayNextSentence();

        }
    }
    public void DisplayNextSentence()
    {
        //Debug.Log("Sentence Count 5: " + sentences.Count);
        if (sentences.Count == 0)
        {
            //Debug.Log("Sentence Count 2: " + sentences.Count);
            EndDialogue();
            return;
        }

        //sentenceNumber -= 1;
        //Debug.Log("Sentence Count 3: " + sentences.Count);
        string sentence = sentences.Dequeue();
        CurrentItem = items.Dequeue();
        //Debug.Log("Sentence Count after Dequeue: " + sentences.Count);
        Debug.Log(sentence);
        Notice.SetActive(true);
        NoticeText.text = sentence;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) & TriggeredRecordPlayer == true)
        {
            Background.Stop();
            Jazz.Stop();
            Rock.Stop();
            Pop.Stop();
            if (CurrentItem == "Jazz Record")
            {
                Jazz.Play();
                FindObjectOfType<DialogueManager_3>().SwitchScene = true;
            }
            else if (CurrentItem == "Rock Record")
            {
                Rock.Play();

            } else if (CurrentItem == "Pop Record"){
                Pop.Play();

            };
            DisplayNextSentence();
        }
        else if (Input.GetKeyDown(KeyCode.N)& TriggeredRecordPlayer == true)
        {
            if (CurrentItem == "Jazz Record")
            {
                FindObjectOfType<DialogueManager_3>().SwitchScene = false;
            };
            DisplayNextSentence();
        }
    }

    void EndDialogue()
    {
        //Debug.Log("Sentence Count 4: " + sentences.Count);
        Debug.Log("End of conversation.");
        //DialogueBox.GetComponent<Renderer>().enabled = false;
        Notice.SetActive(false);
        TriggeredRecordPlayer = false;

    }
}
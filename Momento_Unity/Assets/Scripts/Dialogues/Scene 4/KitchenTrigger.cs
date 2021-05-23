using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenTrigger : MonoBehaviour
{

    public GameObject Notice;
    public GameObject ChickenNoodleSoup;
    public Text NoticeText;
    public bool TriggeredKitchen;
    public List<string> Items;
    public Queue<string> items;
    private Queue<string> sentences;
    private string CurrentItem;
    public List<string> Ingredients;

    private void Start()
    {
        sentences = new Queue<string>();
        items = new Queue<string>();
        TriggeredKitchen = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("You collided with Kitchen");
        if (col.gameObject.name == "Player")
        {

            Ingredients = new List<string>();

            Items = FindObjectOfType<ItemManager>().Items;
            TriggeredKitchen = true;
            foreach (string item in Items)
            {
                
                string sentence = "Cook " + item + "? (Y/N)";
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
        if (Input.GetKeyDown(KeyCode.Y) & TriggeredKitchen == true)
        {
            Ingredients.Add(CurrentItem);
            DisplayNextSentence();
        }
        else if (Input.GetKeyDown(KeyCode.N)& TriggeredKitchen == true)
        {
            DisplayNextSentence();
        }
    }

    void EndDialogue()
    {
        //Debug.Log("Sentence Count 4: " + sentences.Count);
        Debug.Log("End of conversation.");
        //DialogueBox.GetComponent<Renderer>().enabled = false;
        Notice.SetActive(false);
        TriggeredKitchen = false;
        if (Ingredients.Contains("Chicken") & Ingredients.Contains("Noodles") & Ingredients.Contains("Carrot") & Ingredients.Count == 3){
            ChickenNoodleSoup.SetActive(true);
            FindObjectOfType<DialogueTrigger_4_2>().MoveMom = true;
            //yield return new WaitForSeconds(2);
            FindObjectOfType<DialogueTrigger_4_2>().TriggeredMom = true;

        }

    }
}
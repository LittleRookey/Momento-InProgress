using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public string dialogue;
    public Text dialogueText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Input.GetKeyDown(KeyCode.Q)) {
            if (other.CompareTag("Player"))
            {
                Debug.Log(dialogue);
                dialogueText.text = dialogue;
            }
        }
    }

}

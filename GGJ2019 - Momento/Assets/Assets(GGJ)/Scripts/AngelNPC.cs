using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AngelNPC : MonoBehaviour
{
    [SerializeField]
    public GameObject TextUI;

    public string inputText;

    public Text displayText;

    private int i = -1;
    private bool done;
    private string outputString;
    private int j = -1;
    private string[] angelSays;
    private int k = 0;
    private bool active;

    private void Start()
    {
        angelSays = new string[2];
        angelSays[0] = "You lived a good, moral life." +
            " I want to give you something in return for your good deeds. What would you like?";
        angelSays[1] = "After finding diary, angel says]: You want to return home? I’ll take you there.";
        inputText = angelSays[0];
        j++;
        displayText.text = inputText;
        TextUI.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            j++;
            if (j < angelSays.Length)
            {
                displayText.text = angelSays[j];
                TextUI.gameObject.SetActive(false);
                SceneManager.LoadScene(4);
            }
            else
            {
                return;
            }
            
        }
    }

    private void Says(string s)
    {
        if (j < angelSays.Length)
        {
            j++;
            inputText = angelSays[j];
            displayText.text = inputText;
        }
    }

    private string Typewrite(string text)
    {
        i++;
        char[] characters = text.ToCharArray();
        outputString = outputString + characters[i].ToString();
        if (i == characters.Length - 1)
        {
            done = true;
        }
        return outputString;
    }
}

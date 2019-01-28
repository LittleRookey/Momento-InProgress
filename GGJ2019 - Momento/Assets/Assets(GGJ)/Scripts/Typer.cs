using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text inputText;

    public Text displayText;

    private int i = -1;
    private bool done;
    private string outputString;


    // Update is called once per frame
    void Update()
    {
        if(!done)
        {
            displayText.text = Typewrite(inputText.text);
        }
    }

    private string Typewrite(string text)
    {
        i++;
        char[] characters = text.ToCharArray();
        outputString = outputString + characters[i].ToString();
        if(i == characters.Length -1)
        {
            done = true;
        }
        return outputString;
    }
}

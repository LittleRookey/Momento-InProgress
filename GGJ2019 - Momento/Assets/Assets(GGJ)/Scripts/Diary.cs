using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Diary : MonoBehaviour
{
    public Text story;

    private string explanations1;
    private string explanations2;

    private void Start()
    {
        explanations1 = "Dear Diary, Today was the third day of our family trip. " +
            "Sam has always wanted to come to the amusement park, " +
            "so we finally brought him here. As soon as we entered the park," +
            " he dashed off with Andrew to line up for the roller coaster ride.";
        explanations2 = "Isabelle didn’t want to take a ride, " +
            "so I stayed with her and waited for the kids." +
            " A staff member then asked us if we wanted to take a family photo." +
            " We happily accepted his offer.";
    }
    private void Update()
    {
        
    }



}

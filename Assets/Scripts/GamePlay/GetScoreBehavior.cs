using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Update Score board inforamtion 
public class GetScoreBehavior : MonoBehaviour
{
    private Text _text;

    private void Awake()
    {
        //Get a refrence to the test box 
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        //Sets the iformation with a text to let the user know the current score 
        _text.text = "Score: " + ScoreManagerBehavior.currentScore.ToString();
    }
}

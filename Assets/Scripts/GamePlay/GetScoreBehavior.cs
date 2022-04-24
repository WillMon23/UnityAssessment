using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreBehavior : MonoBehaviour
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        _text.text = "Score: " + ScoreManagerBehavior.currentScore.ToString();
    }
}

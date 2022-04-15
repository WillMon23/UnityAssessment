using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreBehavior : MonoBehaviour
{
    [SerializeField] private Text _text;
    private void Update()
    {
        _text.text = "Score: " + ScoreManagerBehavior.currentScore.ToString();
    }
}

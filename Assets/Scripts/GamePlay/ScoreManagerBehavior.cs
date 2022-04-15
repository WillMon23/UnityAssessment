using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerBehavior : MonoBehaviour
{
    public static int currentScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        currentScore += 10;
    }
}

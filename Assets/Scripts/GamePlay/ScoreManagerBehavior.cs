using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handldes the point in the game 
public class ScoreManagerBehavior : MonoBehaviour
{
    //The games current score 
    public static int currentScore = 0;

    //Checks on the collision with another object
    private void OnCollisionEnter(Collision collision)
    {
        //if the gameobject is tagged with "Floor"
        if(collision.gameObject.tag == "Floor")
          //Increase the current score by 10 points 
          currentScore += 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Handles the results after players death 
public class DeathBehavior : MonoBehaviour
{
    //How low a player can go before they disapear 
    public float deathTrashHold = 10;
    //Contains a refrence to the players health behaviour
    private HealthBehavior _health;
    //Handles the Test to be displayed once the game is paused 
    [SerializeField] private Text _pauseState;
    //Contains a refence to the pause event behavior
    [SerializeField] private PauseMenuBehavior _pause;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the health component
        _health = GetComponent<HealthBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the heath is euqal or less then 0. . .
        if (_health.Health <= 0)
        {
            //call the pause game event
            _pause.PauseGame();
            //Lets the player know they ra out of gas 
            _pauseState.text = "Ran Out Of Gas!";
        }
        //if the players Y psition is less then or equal to the death trash hold. . .
        if (transform.position.y <= -deathTrashHold)
        {
            //call the pause game event
            _pause.PauseGame();
            //Lets the player know they fell
            _pauseState.text = "You Fell!";
        }
    }
}

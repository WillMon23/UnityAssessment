using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles player current health 
public class HealthBehavior : MonoBehaviour
{
    //Players health value
    [SerializeField]
    private float _health;

    //Health value proporty 
    public float Health { get { return _health; } set { _health = value; } }
    
    //Handles user damage taken values 
    public void TakeDamaage(float damageTaken)
    {
        //Reduces the health value by the damage taken
        _health -= damageTaken;
    }

    private void FixedUpdate()
    {
        //reduces the health on every fixed update by delta time
        _health -= Time.fixedDeltaTime;
    }
}

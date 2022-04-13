using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;

    public float Health { get { return _health; } set { _health = value; } }
    
    public void TakeDamaage(float damageTaken)
    {
        _health -= damageTaken;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}

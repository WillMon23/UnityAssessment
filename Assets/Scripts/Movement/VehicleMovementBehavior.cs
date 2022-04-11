using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovementBehavior : MonoBehaviour
{
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

    }

    public void ForwardMovement()
    {

    }

}


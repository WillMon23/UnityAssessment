using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereToVehicleMovement : MonoBehaviour
{
    //Get the refrence to the rigidbody 
    [SerializeField] private Rigidbody _rigidbody;
    //Sets some adjustable values for forward speed max speed and minimal speed 
    [SerializeField] private float _forwardSpeed, _maxSpeed, _minSpeed;
    //Sets the turing speed 
    [SerializeField] private float _turnSpeed;

    //Check if the car is jumping at the moment 
    bool _jump;
    //The force being applied to the leap 
    [SerializeField]
    float _jumpForce;

    //The direction that is bring turned 
    private float _turnDirection;

    //Jst the direction and speed being applied 
    private float _moveInputAndSpeed;


    // Start is called before the first frame update
    void Start()
    {
        //Removes the car from the sphere 
        _rigidbody.transform.parent = null;
        //Makes sure that there is no turning at the start of the car 
        _turnDirection = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //Sets car postions to shpere 
        transform.position = _rigidbody.transform.position;

        transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);

        //Sets the multiplies the direction by the speed and sets it to a variable 
        _moveInputAndSpeed = _turnDirection * _turnSpeed;

        //Get the transform rotation and set it by the Quaterion allowing me to set it X,Y,Z by scaling it by a Vector 3 
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, _moveInputAndSpeed * Time.deltaTime, 0f));
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.right * _moveInputAndSpeed, ForceMode.Acceleration);

        _rigidbody.AddForce(Vector3.forward * _forwardSpeed, ForceMode.Acceleration);

        if (_jump && transform.position.y <= .3 && transform.position.y >= -1 )
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _turnDirection = 0;
        }
        _jump = false;
    }

    //Which ever button clicks this will insert a type of turn value 1 or -1;
    public void ButtonTurnDirection(int turnDirection) 
    {
        if (_turnDirection != turnDirection && _turnDirection != 0)
            _turnDirection = 0;
        else 
            _turnDirection += turnDirection;
    }

    //Event created for a slider
    //Slider will adjust the speed going forwards 
    public void Acceleration(float currentForwardSpeed)
    {
        _forwardSpeed = currentForwardSpeed;
    }

    //Event for when to jump 
    public void TryToJump()
    {
        _jump = true;
    }
}

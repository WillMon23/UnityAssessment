using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Meant to simulate vehicle movemnt by attaching a ball 
//to car asset in order to give a round turn and feel 
public class VehicleMovementBehavior : MonoBehaviour
{ 
    //Gets the rigidbody of the call it's attached ti
    private Rigidbody _rigidbody;
    
    //Gives the car a max speed 
    [SerializeField]
    private float _maxSpeed;
    //The current speed
    [SerializeField]
    private float _speed;
    //The hieght of the jump 
    [SerializeField]
    private float _hieght;
    //Checks if there in the middle of a jump
    private bool _jump = false;

    //Sets a turning direction 
    private float _direction;
    //is the magnitude and direction 
    Vector3 _velocity;

    public float XDirection { get { return _direction; } set { _direction = value; } }
    public bool Jump { get { return _jump; } set { _jump = value; } }

    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        //sets the velocity to be the direction times the speed and vector (1,0,0);
        _velocity = transform.right * XDirection * _speed * Time.deltaTime;

        // if the velocity magnitude is higher then the max speed
        if (_velocity.magnitude > _maxSpeed)
            //normalize the current velocity the multiply the normalixed vector by the max speed 
            _velocity = _velocity.normalized * _maxSpeed * Time.deltaTime;
        //Changes the position of that rigidbody 
        _rigidbody.position = transform.position + _velocity;

        //capable of jumping and the position on the Y is not less then 0
        if (Jump && transform.position.y <= 0)
            _rigidbody.AddForce(new Vector3(0, _hieght, 0), ForceMode.Impulse);
        
        //if the object position Y is less then or equal to 0 
        if (transform.position.y <= 0)
            //You can;t jump 
            _jump = false;

    }

    //Changes the direction to br negative 1
    public void TrunLeft() { _direction = -1; }

    //Changes the direction to be 1
    public void TurnRight() { _direction = 1; }

    //Tries to make the car jump 
    public void MakeItJump() { _jump = true; }
}

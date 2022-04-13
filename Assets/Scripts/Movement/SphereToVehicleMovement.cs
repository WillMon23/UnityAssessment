using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereToVehicleMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _forwardSpeed, _maxSpeed, _minSpeed;

    [SerializeField] private float _turnSpeed;

    private float _gravityForce;
    private bool _grounded;

    public LayerMask _whatIsGround;
    public float _groundRayLength;
    public Transform _groundRayPoint;


    bool _jump;

    private float _turnDirection;

    private float _moveInputAndSpeed;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody.transform.parent = null;
        _turnDirection = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //Sets car postions to shpere 
        transform.position = _rigidbody.transform.position;

        //Sets the multiplies the direction by the speed and sets it to a variable 
        _moveInputAndSpeed = _turnDirection * _turnSpeed;

        //Get the transform rotation and set it by the Quaterion allowing me to set it X,Y,Z by scaling it by a Vector 3 
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, _moveInputAndSpeed * Time.deltaTime, 0f));
    }

    private void FixedUpdate()
    {
        _grounded = false;
        RaycastHit hasHit;

        //borad cast a line from the point of orgin to the going doen the Y-axis if the hit a layer labled "Floor"
        if(Physics.Raycast(_groundRayPoint.position, -transform.up, out hasHit, _whatIsGround))
        {
            //Set the grounded bool to be true
            _grounded = true;
        }

        if (_grounded)
        {
            _rigidbody.AddForce(Vector3.forward * _forwardSpeed, ForceMode.Acceleration);
        }
        else
            _rigidbody.AddForce(Vector3.up * -_gravityForce * _forwardSpeed * 10);

    }

    //Which ever button clicks this will insert a type of turn value 1 or -1;
    public void ButtonTurnDirection(int turnDirection) 
    {
        if (_turnDirection != turnDirection && _turnDirection != 0)
            _turnDirection = 0;
        else 
            _turnDirection = turnDirection;
    }

    //Event created for a slider
    //Slider will adjust the speed going forwards 
    public void Acceleration(float currentForwardSpeed)
    {
        _forwardSpeed = currentForwardSpeed;
    }
}

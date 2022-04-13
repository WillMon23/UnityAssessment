using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleMovementBehavior : MonoBehaviour
{ 
    private Rigidbody _rigidbody;

    [SerializeField]
    private float _maxSpeed;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _hieght;

    bool _jump = false;


    private float _direction;
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
        _velocity = transform.right * XDirection * _speed * Time.deltaTime;


        if (_velocity.magnitude > _maxSpeed)
            _velocity = _velocity.normalized * _maxSpeed * Time.deltaTime;

        _rigidbody.position = transform.position + _velocity;


        if (Jump && transform.position.y <= 0)
            _rigidbody.AddForce(new Vector3(0, _hieght, 0), ForceMode.Impulse);

        if (transform.position.y <= 0)
            _jump = false;

    }

    public void TrunLeft() { _direction = -1; }

    public void TurnRight() { _direction = 1; }

    public void MakeItJump() { _jump = true; }
}

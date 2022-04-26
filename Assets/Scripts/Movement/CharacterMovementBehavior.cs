using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lodis Implamentation of of mouse movemnt 
public class CharacterMovementBehavior : MonoBehaviour
{
    //Handles position and game physics 
    private Rigidbody _rigidbody;

    //gets a refrence to the  camera 
    private Camera _camera;
    // Start is called before the first frame update
    void AWake()
    {
        //Gets the rigidbody from this gameobject
        _rigidbody = GetComponent<Rigidbody>();
        //Gets the Main Camera in the scene
        _camera = Camera.main;
    }

    // Update is called once per frame
    void FixUpdate()
    {
        //Gets a location that poisnt to the screen 
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        //Gets inforamtion back from raycast
        RaycastHit hitInfo;


        if(Physics.Raycast(ray, out hitInfo))
        {
            //Gets the direction from the mouse and the player
            Vector3 direction = (hitInfo.point - transform.position).normalized;
            //Sets the direction without the Y axis 
            direction = new Vector3(direction.x, 0, direction.z);
            //Sets the rigidbody to be that direction times a speed and the fixed update 
            _rigidbody.velocity = direction * 50 * Time.fixedDeltaTime;
            
        }
    }
}

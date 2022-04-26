using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Handles the position and the lifespand after the floor is created
public class DestroyFloorBehavior : MonoBehaviour
{
    //Time when this object will destroy after created 
    [SerializeField] float _experation = 1;
    //Time counter 
    float _floorTimer;
    
    //Updates once per frame 
    void Update()
    {
        //if the floor timer pass its expersion timer. . .
        if (_floorTimer >= _experation)
            //Change the floors Y position by negative deltatime
            transform.position = new Vector3 (transform.position.x, transform.position.y - Time.deltaTime, transform.position.z);
        //if the floor timer is greater then the experation times it self. . .
        if(_floorTimer >= _experation * _experation)
            //Distroy this game object
            Destroy(gameObject);
        //Increase the _floorTimer plus it self plus delta time
        _floorTimer += Time.deltaTime;
    }
}

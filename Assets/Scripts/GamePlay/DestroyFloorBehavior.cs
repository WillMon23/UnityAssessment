using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFloorBehavior : MonoBehaviour
{
    //Time when this object will destroy after created 
    [SerializeField] float _exeration = 1;
    //Time counter 
    float _floorTimer;
    
    void Update()
    {
        if (_floorTimer >= _exeration)
        transform.position = new Vector3 (transform.position.x, transform.position.y - Time.deltaTime, transform.position.z);

        if(_floorTimer >= _exeration * _exeration)
            Destroy(gameObject);
        _floorTimer += Time.deltaTime;
    }
}

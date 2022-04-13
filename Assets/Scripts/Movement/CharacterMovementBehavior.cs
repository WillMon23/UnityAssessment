using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Camera _camera;
    // Start is called before the first frame update
    void AWake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void FixUpdate()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;


        if(Physics.Raycast(ray, out hitInfo))
        {
            Vector3 direction = (hitInfo.point - transform.position).normalized;
            direction = new Vector3(direction.x, 0, direction.z);
            _rigidbody.velocity = direction * 50 * Time.fixedDeltaTime;
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehavior : MonoBehaviour
{
    [SerializeField]
    Transform _player;
    // Update is called once per frame

    private void Awake()
    {
        transform.position = new Vector3(_player.position.x + -0.01316148f, 5f, _player.position.z + -10f);
    }
    void Update()
    {
        transform.position = new Vector3(_player.position.x + -0.01316148f, 5f, _player.position.z + -10f); 
    }
}

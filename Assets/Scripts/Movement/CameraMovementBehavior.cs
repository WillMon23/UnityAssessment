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
        transform.position = new Vector3(_player.position.x, 2f, _player.position.z - 3.5f);
    }
    void Update()
    {
        transform.position = new Vector3(_player.position.x ,3f, _player.position.z - 10.5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Camera meant to follow the the postion of of the player 
public class CameraMovementBehavior : MonoBehaviour
{
    //Gets a refrence to that player
    [SerializeField]
    Transform _player;
    private void Awake()
    {
        //Once the game starts based on some position of the player the camera will face 
        transform.position = new Vector3(_player.position.x, 2f, _player.position.z - 3.5f);
    }
    void Update()
    {
        //Updates the postion of the camera based on the player position
        transform.position = new Vector3(_player.position.x ,3f, _player.position.z - 10.5f);
    }
}

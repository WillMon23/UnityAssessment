using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnerBehavior : MonoBehaviour
{
    //Sets the game objects that are going to be spawned 
    [SerializeField] private GameObject[] _floorSpawner;

    //Time being callculated 
    private float _spawnTimer = 0;

    //Time till next cooldown
    [SerializeField]
    private float _cooldown;
    // Update is called once per frame
    void Update()
    {
        //variable created to hold a random number 
        //value will be used to place the spawn in one of the random locations 
        int spacedRng = Random.Range(1, 4);
        //Witch ransom floor will spawn 
        int spawnrng = Random.Range(0, 3);
        //Holds the game object picked out if the array 
        GameObject newFloor = (GameObject)_floorSpawner.GetValue(spawnrng);

        //Clones the object to the scene 
        if (_spawnTimer >= _cooldown)
        {
            Instantiate(newFloor, new Vector3(transform.position.x * spacedRng, 0, transform.position.z + 30), new Quaternion());
            //Destroys this compnent 
            Destroy(this);
        }
        //adds delta time to the spawntimer
        _spawnTimer += Time.deltaTime;
    }
}

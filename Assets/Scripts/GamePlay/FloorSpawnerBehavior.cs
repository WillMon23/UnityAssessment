using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorSpawner;
    private float _spawnTimer = 0, _lifeTime = 0;
    GameObject clonedfloor;


    [SerializeField]
    private float _cooldown;
    [SerializeField]
    private float _timedOut;
    // Update is called once per frame
    void Update()
    {
        int spacedRng = Random.Range(1, 4);
        int Spawnrng = Random.Range(0, _floorSpawner.Length);
        GameObject newFloor = (GameObject)_floorSpawner.GetValue(Spawnrng);

        if (_spawnTimer >= _cooldown)
        {
            clonedfloor =  Instantiate(newFloor, new Vector3(transform.position.x * spacedRng,0, transform.position.z + 40), new Quaternion());
            _spawnTimer = 0;
        }


        if (_lifeTime >= _timedOut)
        {
            Destroy(this);
            _lifeTime = 0;
        }

        _spawnTimer += Time.deltaTime;
        _lifeTime += Time.deltaTime;
    }
}

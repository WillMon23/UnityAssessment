using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorSpawner;
    private float _spawnTimer = 0, _lifeTime = 0;

    [SerializeField]
    private float _cooldown;
    [SerializeField]
    private float _timedOut;
    // Update is called once per frame
    void Update()
    {
        int spacedRng = Random.Range(0, 3);
        int Spawnrng = Random.Range(0, 3);
        GameObject newFloor = (GameObject)_floorSpawner.GetValue(Spawnrng);

        if (_spawnTimer >= _cooldown && spacedRng < 2)
        {
            Instantiate(newFloor, new Vector3(transform.position.x, 0, transform.position.z + 30), new Quaternion());
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

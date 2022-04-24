using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    public float deathTrashHold = 10;
    private HealthBehavior _health;
    [SerializeField] private PauseMenuBehavior _pause;
    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<HealthBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_health.Health <= 0)
            _pause.PauseGame();

        if (transform.position.y <= -deathTrashHold)
            _pause.PauseGame();
     


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathBehavior : MonoBehaviour
{
    public float deathTrashHold = 10;
    private HealthBehavior _health;
    [SerializeField] private Text _pauseState;
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
        {
            _pause.PauseGame();
            _pauseState.text = "Ran Out Of Gas!";
        }

        if (transform.position.y <= -deathTrashHold)
        {
            _pause.PauseGame();
            _pauseState.text = "You Fell!";
        }
    }
}

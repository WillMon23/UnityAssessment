using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviro : MonoBehaviour
{
    //To get the refence of the slider 
    private Slider _slider;
    //The player health value 
    [SerializeField]
    private HealthBehavior _playerHeath;

    // Start is called before the first frame update
    void Awake()
    {
        //Gets the refrence of the slider 
        _slider = GetComponent<Slider>();
        _slider.maxValue = _playerHeath.Health;
    }

    // Update is called once per frame
    void Update()
    {
        //Updates the value from the player tp the slider
        _slider.value = _playerHeath.Health;
    }
}

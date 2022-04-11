using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviro : MonoBehaviour
{
    private Slider _slider;
    [SerializeField]
    private HealthBehavior _playerHeath;

    // Start is called before the first frame update
    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _playerHeath.Health;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _playerHeath.Health;
    }
}

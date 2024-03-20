using UnityEngine.UI;
using UnityEngine;

public class HealthViewSlider : HealthView
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _health.GetMaxHealth();
        _slider.value = _health.GetCurrentHealth();
    }

    public override void DisplayAmount(float value)
       => _slider.value = value;
}
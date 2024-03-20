using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthViewSmoothSlider : HealthView
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _step = 10f;

    private void Start()
    {
        _slider.maxValue = _health.GetMaxHealth();
        _slider.value = _health.GetCurrentHealth();
    }

    public override void DisplayAmount(float value)
    {
        StartCoroutine(SlowlyChangeValue(value));
    }

    private IEnumerator SlowlyChangeValue(float targetValue)
    {
        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _step * Time.deltaTime);
            yield return null;
        }
    }
}
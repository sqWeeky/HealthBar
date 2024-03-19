using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HealthChanger))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _imageBar;
    [SerializeField] private Text _textBar;
    [SerializeField] private Slider _slider_1;
    [SerializeField] private Slider _slider_2;

    private float _fill;
    private HealthChanger _healthChanger;
    private float _step = 0.5f;

    private void Start()
    {
        _healthChanger = GetComponent<HealthChanger>();
        _slider_1.maxValue = _healthChanger.GetMaxHealth();
        _slider_2.maxValue = _healthChanger.GetMaxHealth();
    }

    private void Update()
    {
        _fill = Convert.ToSingle(_healthChanger.GetCurrentHealth()) / Convert.ToSingle(_healthChanger.GetMaxHealth());
        _imageBar.fillAmount = _fill;
        _textBar.text = $"Çהמנמגüו:  {_healthChanger.GetCurrentHealth()} / {_healthChanger.GetMaxHealth()}";
        _slider_1.value = _healthChanger.GetCurrentHealth();
        StartCoroutine(SlowlyChangeValue(_healthChanger.GetCurrentHealth()));
    }

    private IEnumerator SlowlyChangeValue(float targetValue)
    {
        while (_slider_2.value != targetValue)
        {
            _slider_2.value = Mathf.MoveTowards(_slider_2.value, targetValue, _step * Time.deltaTime);
            yield return null;
        }
    }
}

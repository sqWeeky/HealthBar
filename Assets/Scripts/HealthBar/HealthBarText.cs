using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class HealthBarText : HealthView
{
    [SerializeField] private Text _textBar;

    private void Start()
        => _health = GetComponent<Health>();

    public override void DisplayAmount(float value)
       => _textBar.text = $"Çהמנמגüו:  {value} / {_health.GetMaxHealth()}";
}
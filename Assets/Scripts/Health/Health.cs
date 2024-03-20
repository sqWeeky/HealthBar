using UnityEngine;
using System;
using System.Collections;

public class Health : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;

    private int _minHealth = 0;
    public event Action<float> HealthChanged;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
            _currentHealth -= damage;

        _currentHealth = Mathf.Max(_minHealth, _currentHealth);
        HealthChanged?.Invoke(_currentHealth);

        if (_currentHealth == 0)
            Destroy(gameObject);
    }

    public void Heal(int extraHealth)
    {
        if (extraHealth > 0)
            _currentHealth += extraHealth;

        _currentHealth = Mathf.Min(_currentHealth, _maxHealth);
        HealthChanged?.Invoke(_currentHealth);
    }

    public float GetCurrentHealth()
        => _currentHealth;

    public float GetMaxHealth()
        => _maxHealth;
}
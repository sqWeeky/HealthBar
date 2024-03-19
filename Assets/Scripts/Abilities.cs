using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthChanger))]
public class Abilities : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _extraHealth;
    [SerializeField] private Transform _player;

    private HealthChanger _healthChanger;

    private void Start()
    {
        if (_player.TryGetComponent(out HealthChanger healthChanger))
            _healthChanger = healthChanger;
    }

    public void StartAction()
    {
        _healthChanger.TakeDamage(_damage);
    }

    public void Heal()
    {
        _healthChanger.Heal(_extraHealth);
    }
}

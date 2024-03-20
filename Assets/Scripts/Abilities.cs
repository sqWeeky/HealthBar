using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

[RequireComponent(typeof(Health))]
public class Abilities : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _extraHealth;
    [SerializeField] private Health _healthPlayer;

    private Health _health;

    private void Start()
    {
        if (_healthPlayer.TryGetComponent(out Health health))
            _health = health;
    }

    public void Attack()
        => _health.TakeDamage(_damage);

    public void Heal()
        => _health.Heal(_extraHealth);
}
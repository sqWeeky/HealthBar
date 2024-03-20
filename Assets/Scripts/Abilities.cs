using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _extraHealth;
    [SerializeField] private Health _health;

    public void Attack()
        => _health.TakeDamage(_damage);

    public void Heal()
        => _health.Heal(_extraHealth);
}
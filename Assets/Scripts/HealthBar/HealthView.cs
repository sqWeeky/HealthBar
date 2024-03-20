using UnityEngine;

[RequireComponent(typeof(Health))]
public class HealthView : MonoBehaviour
{
    protected Health _health;

    private void Awake()
        => _health = GetComponent<Health>();

    private void OnEnable()
        => _health.HealthChanged += DisplayAmount;

    private void OnDisable()
        => _health.HealthChanged -= DisplayAmount;

    public virtual void DisplayAmount(float value) { }
}
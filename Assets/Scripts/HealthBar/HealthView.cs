using UnityEngine;

public class HealthView : MonoBehaviour
{
    protected Health Health;

    private void Awake()
    {
        Health = FindObjectOfType<Health>();
    }

    private void OnEnable()
        => Health.HealthChanged += DisplayAmount;

    private void OnDisable()
        => Health.HealthChanged -= DisplayAmount;

    public virtual void DisplayAmount(float value) { }
}
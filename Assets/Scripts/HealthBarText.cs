using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HealthChanger))]
public class HealthBarText : MonoBehaviour
{
    [SerializeField] private Text _textBar;

    private HealthChanger _healthChanger;

    private void Start()
    {
        _healthChanger = GetComponent<HealthChanger>();
    }

    private void Update()
    {
        Debug.Log(_textBar.text);
        //(_healthChanger.GetCurrentHealth() / Convert.ToSingle(_healthChanger.GetMaxHealth());
        Debug.LogError(_healthChanger.GetMaxHealth());
        _textBar.text = $"Çהמנמגüו:  {_healthChanger.GetCurrentHealth()} / {_healthChanger.GetMaxHealth()} ";
    }
}

using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthUI  _ui;
    private int _max;
    private int _current;

    public void SetMax(int max)
    {
        _max = max;
        UpdateHp();
    }

    public void SetCurrent(int current)
    {
        _current = current;
        UpdateHp();
    }

    public void ApplyDamage(int damage)
    {
        _current -= damage;
        UpdateHp();
    }

    private void UpdateHp()
    {
        _ui.UpdateHealth(_max,_current);
    }
}

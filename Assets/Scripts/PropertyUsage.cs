using UnityEngine;

public class PropertyUsage : MonoBehaviour, IDamageable
{
    private float life;
    private float maxLife = 100;

    public float Life
    {
        get => life;
        private set
        {
            if (value < 0)
            {
                value = 0;
            }
            else if (value > maxLife)
            {
                value = maxLife;
            }

            life = value;
        }
    }

    private void Start()
    {
        Life = maxLife;
    }

    public void TakeDamage(float damage)
    {
        Life -= damage;
        if (life <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{name} has Died!", this);
    }
}

public interface IDamageable
{
    public void TakeDamage(float damage);
}
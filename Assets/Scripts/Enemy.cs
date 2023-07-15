using UnityEngine;

public class Enemy2: MonoBehaviour
{
    [SerializeField] private float damage = 5;
    KeyCode attackKey = KeyCode.Space;
    [SerializeField] private GameObject target;
    public IDamageable damageable;
    private void Awake()
    {
        damageable = target.GetComponent<IDamageable>(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            damageable.TakeDamage(damage);
        } 
    }

}
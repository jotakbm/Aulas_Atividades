using System.Collections;
using UnityEngine;

#region Data
public abstract class WeaponData : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private string weaponDescription;
    [SerializeField] private Sprite weaponSprite;
}

public class MeleeWeaponData : WeaponData
{
    public int damage;
}

public class ProjectileWeaponData : WeaponData
{
    public float shootDelay = 0.75f;
    public GameObject projectilePrefab;
}

public class GunWeaponData : ProjectileWeaponData
{
    public int maxAmmo;
    public float reloadTime;
}
public class MagicWeaponData : ProjectileWeaponData
{
    public int manaCost;
}
#endregion

#region Weapon
public abstract class Weapon<T> : MonoBehaviour
{
    [SerializeField] protected T data;
    public virtual void TryAttack()
    {
        if (CanAttack())
        {
            Attack();
        }
    }
    public abstract void Attack();
    protected abstract bool CanAttack();
    public virtual string GetDescription()
    {
        return "Weapon";
    }
}

public class MeleeWeapon : Weapon<MeleeWeaponData>
{
    public override void Attack()
    {
        // Faz animação de ataque
        // A colisão da animação causa o dano no inimgo(?)
    }

    protected override bool CanAttack()
    {
        // Só pode atacar, após finalizar a animação de ataque.
        return true;
    }
}

public abstract class ProjectileWeapon<T> : Weapon<T> where T : ProjectileWeaponData
{
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected Transform projectilePoint;
    [Min(0)]
    [SerializeField] protected float shootDelay;
    protected float shootDelayTimer;

    private void Update()
    {
        shootDelayTimer -= Time.deltaTime;
    }

    public override void Attack()
    {
        Instantiate(projectile, projectilePoint.position, Quaternion.identity);
        shootDelayTimer = data.shootDelay;
    }

    protected override bool CanAttack()
    {
        return shootDelayTimer <= 0;
    }
}

public class MagicWeapon : ProjectileWeapon<MagicWeaponData>
{
    public override void Attack()
    {
        base.Attack();
        // remove mana do jogador
    }

    protected override bool CanAttack()
    {
        return base.CanAttack(); // checa se o jogador tem mana para atacar
    }
}

public class GunWeapon : ProjectileWeapon<GunWeaponData>
{
    public int actualAmmo;
    private bool isReloading;

    public override void Attack()
    {
        base.Attack();
        actualAmmo--;
    }

    public void Reload()
    {
        if (isReloading) return;
        StartCoroutine(ReloadEnum());
    }

    protected override bool CanAttack()
    {
        return base.CanAttack() && !isReloading && actualAmmo > 0;
    }

    IEnumerator ReloadEnum()
    {
        isReloading = true;
        yield return new WaitForSeconds(data.reloadTime);
        actualAmmo = data.maxAmmo;
        isReloading = false;
    }
}
#endregion
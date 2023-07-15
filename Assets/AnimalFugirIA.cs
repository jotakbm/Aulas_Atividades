using UnityEngine;

namespace BrasilRP
{
    public abstract class IA : MonoBehaviour
    {
        [SerializeField] protected float speed = 2;
        public abstract void Mover(Vector3 targetPosition);
    }

    public class AnimalFugirIA : IA
    {
        public override void Mover(Vector3 targetPosition)
        {
            Vector3 dir = targetPosition - transform.position;
            transform.position -= speed * Time.deltaTime * dir.normalized;
        }
    }

    public class AnimalSeguirIA : IA
    {
        public override void Mover(Vector3 targetPosition)
        {
            Vector3 dir = targetPosition - transform.position;
            transform.position += speed * Time.deltaTime * dir.normalized;
        }
    }

    public interface IDamageable
    {
        public void TakeDamage(int value);
    }
}
using UnityEngine;

namespace BrasilRP
{
    public class Animal : MonoBehaviour
    {
        [SerializeField] private float minDistance = 3;
        [SerializeField] private Transform player;
        private AnimalFugirIA IA;

        private void Awake()
        {
            IA = GetComponent<AnimalFugirIA>();
        }

        private void Update()
        {
            if (Vector3.Distance(player.position, transform.position) <= minDistance)
            {
                IA.Mover(player.position);
            }
        }
    }
}
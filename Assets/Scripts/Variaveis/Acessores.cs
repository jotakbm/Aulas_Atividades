using UnityEngine;

namespace Exemplos.Acessores
{
    // Considere a classe como o jogador
    public class Acessores : MonoBehaviour
    {
        // public: Qualquer classe pode acessar essa variavel ou método.
        public bool isInvencible;

        // private: Apenas a própria classe pode acessar essa variavel ou método.
        private int maxLife;
        private int life;

        public int Life { get => life; private set => life = value; }

        private void Start()
        {
            life = maxLife;
        }

        public void TakeDamage(int value)
        {
            Life -= value;

            if (Life <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log($"{name} Morreu!", this);
            Debug.Log($"Ainda restam {AcessoresEspeciais.enemyAmount} inimigos a serem motos.");
        }
    }

    // Considere a classe como um inimigo
    public class AcessoresEspeciais : MonoBehaviour
    {
        // Valores estáticos são gravados na própria classe, e não em sua instancia. Desta forma, esse valor é único para todo o projeto (o mesmo é compartilhado para todos).
        // Para acessa-lo, basta usar o nome da classe.valor.
        // (Ex: Enemy.enemyAmount;)
        public static int enemyAmount;

        // Valores constantes são gravados na própria classe, e não em sua instancia. Desta forma, esse valor é único para todo o projeto (o mesmo é compartilhado para todos).
        // Comumente o nome é inteiro escito em maiúsculo como no exemplo abaixo. Isso facilita saber que se trata de uma Constante.
        // Esse valor NUNCA poderá ser alterado em tempo de execução e só deve ser usado em casos que seu valor seja sempre o mesmo e que você saiba disso.
        // Para acessa-lo, basta usar o nome da classe.valor.
        // (Ex: Enemy.VALORUM;)
        public const int VALORUM = 1;
        Acessores target;

        private void OnEnable()
        {
            enemyAmount++;
        }

        private void Start()
        {
            if (!target.isInvencible)
            {
                Debug.Log(target.Life);
                target.TakeDamage(5);
            }
        }

        private void OnDisable()
        {
            enemyAmount--;
        }

    }
}
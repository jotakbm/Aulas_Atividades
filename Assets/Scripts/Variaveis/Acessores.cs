using UnityEngine;

namespace Exemplos.Acessores
{
    // Considere a classe como o jogador
    public class Acessores : MonoBehaviour
    {
        // public: Qualquer classe pode acessar essa variavel ou m�todo.
        public bool isInvencible;

        // private: Apenas a pr�pria classe pode acessar essa variavel ou m�todo.
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
        // Valores est�ticos s�o gravados na pr�pria classe, e n�o em sua instancia. Desta forma, esse valor � �nico para todo o projeto (o mesmo � compartilhado para todos).
        // Para acessa-lo, basta usar o nome da classe.valor.
        // (Ex: Enemy.enemyAmount;)
        public static int enemyAmount;

        // Valores constantes s�o gravados na pr�pria classe, e n�o em sua instancia. Desta forma, esse valor � �nico para todo o projeto (o mesmo � compartilhado para todos).
        // Comumente o nome � inteiro escito em mai�sculo como no exemplo abaixo. Isso facilita saber que se trata de uma Constante.
        // Esse valor NUNCA poder� ser alterado em tempo de execu��o e s� deve ser usado em casos que seu valor seja sempre o mesmo e que voc� saiba disso.
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
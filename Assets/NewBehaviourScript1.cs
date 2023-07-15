using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Enemy enemy = new Enemy();
    private void Start()
    {
        enemy.TakeDamage(5);
        enemy.life = 5;
    }

    private void Update()
    {

    }
}

//Acessor + Tipo + Nome
public class Enemy : MonoBehaviour
{
    //Acessor + Tipo + Nome + Valor(opcional)
    private string enemyName;
    public int life;
    private float speed;
    private bool isDead;
    private char caracter;

    //Acessor + Tipo de retorno + Nome + Parametros(opcional)
    public void TakeDamage(int value)
    {
        life -= value;
    }
}

// Script -> Arquivo de texto (.cs)
// Classe -> Onde há as informações do código
// Metodos -> Ações
// Variaveis -> Valores
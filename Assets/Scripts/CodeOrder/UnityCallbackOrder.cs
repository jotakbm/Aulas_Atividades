using UnityEngine;

// Acesse o link para saber mais:
// https://docs.unity3d.com/Manual/ExecutionOrder.html
public class UnityCallbackOrder : MonoBehaviour
{
    #region Inicializa��o
    private void Awake()
    {
        // Chamado uma �nica vez assim que o objeto se tornar ativo na cena. � a primeira coisa a ser chamada.
        // Geralmente usado para inicializar variaveis n�o primitivas. (ou seja, variaveis que podem ser nulas, como instancia de classes)
        // Exemplo: Buscar um script de X tipo no pr�prio objeto usando "GetComponent<TIPO>();" para salvar em uma variavel previamente criada e n�o atriubida (nula);
    }

    private void OnEnable()
    {
        // Chamado todas as vezes que o objeto for ativado em cena.
        // Geralmente usado para resetar valores pare reutilizar o objeto em cena sem destru�-lo e criar um novo.
        // Exemplo: Resetar a vida do inimigo e reposiciona-lo, ou adicionar em um contador de inimigos.
        // (Ex: Manager.enemyAmount++;)
    }

    private void Start()
    {
        // Chamado uma �nica vez assim que o objeto se tornar ativo na cena. � chamado ap�s o Awake e o OnEnable.
        // Geralmente usado para inicializar variaveis, chamar m�todos de outros scripts, ou fazer os primeiros ajustes do objeto.
        // Exemplo: Acessar a classe de atributos do personagem, e igualar os valores atuais com os valores m�ximos.
        // (EX: life = maxLife;) 
    }
    #endregion

    #region Update
    private void FixedUpdate()
    { 
        // Chamada a cada frame do jogo. � o primeiro dos metodos de Update a ser executado.
        // Geralmente usado para trabalhar com f�sica.
        // Exemplo: Movimenta��o do pesonagem.
    }

    private void Update()
    {
        // Chamada a cada frame do jogo. � o segundo dos metodos de Update a ser executado.
        // � o mais utilizado e padr�o para l�gicas que precisam ser executadas a cada frame.
        // Exemplo: Checar a tecla pessionada pelo jogador no frame atual, para ent�o executar alguma a��o.
    }

    private void LateUpdate()
    {
        // Chamada a cada frame do jogo. � o ultimo dos metodos de Update a ser executado.
        // Raramente � utilizado, e serve para garantir funcionamentos que previamente foram executados no update. (casos especificos)
        // Exemplo: Sistema de camera seguir o personagem.
    }
    #endregion

    #region Finaliza��o
    private void OnDisable()
    {
        // Chamado todas as vezes que o objeto for desativado em cena.
        // Geralmente utilizado para resetar valores ou simplesmente chamar eventos relacionados.
        // Exemplo: Com a morte do inimigo, retire 1 do total de inimigos em cena.
        // (Ex: Manager.enemyAmount--;)
    }

    private void OnDestroy()
    {
        // Chamado assim que o objeto for destru�do, e portanto, uma �nica vez. � o ultimo meto a ser chamado.
        // Age semelhante ao OnDisable, e geralmente � utilizado quando deseja que um comportamento seja realizado ao destruir o objeto.
        // (Dependendo da estrutura do jogo, utilizar� s� OnDisable ou OnDestroy)
        // Exemplo: Adicionar pontua��o ao jogador.
        // (EX: Manager.score += 50;)
    }
    #endregion
}

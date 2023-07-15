using UnityEngine;

// Acesse o link para saber mais:
// https://docs.unity3d.com/Manual/ExecutionOrder.html
public class UnityCallbackOrder : MonoBehaviour
{
    #region Inicialização
    private void Awake()
    {
        // Chamado uma única vez assim que o objeto se tornar ativo na cena. É a primeira coisa a ser chamada.
        // Geralmente usado para inicializar variaveis não primitivas. (ou seja, variaveis que podem ser nulas, como instancia de classes)
        // Exemplo: Buscar um script de X tipo no próprio objeto usando "GetComponent<TIPO>();" para salvar em uma variavel previamente criada e não atriubida (nula);
    }

    private void OnEnable()
    {
        // Chamado todas as vezes que o objeto for ativado em cena.
        // Geralmente usado para resetar valores pare reutilizar o objeto em cena sem destruí-lo e criar um novo.
        // Exemplo: Resetar a vida do inimigo e reposiciona-lo, ou adicionar em um contador de inimigos.
        // (Ex: Manager.enemyAmount++;)
    }

    private void Start()
    {
        // Chamado uma única vez assim que o objeto se tornar ativo na cena. É chamado após o Awake e o OnEnable.
        // Geralmente usado para inicializar variaveis, chamar métodos de outros scripts, ou fazer os primeiros ajustes do objeto.
        // Exemplo: Acessar a classe de atributos do personagem, e igualar os valores atuais com os valores máximos.
        // (EX: life = maxLife;) 
    }
    #endregion

    #region Update
    private void FixedUpdate()
    { 
        // Chamada a cada frame do jogo. É o primeiro dos metodos de Update a ser executado.
        // Geralmente usado para trabalhar com física.
        // Exemplo: Movimentação do pesonagem.
    }

    private void Update()
    {
        // Chamada a cada frame do jogo. É o segundo dos metodos de Update a ser executado.
        // É o mais utilizado e padrão para lógicas que precisam ser executadas a cada frame.
        // Exemplo: Checar a tecla pessionada pelo jogador no frame atual, para então executar alguma ação.
    }

    private void LateUpdate()
    {
        // Chamada a cada frame do jogo. É o ultimo dos metodos de Update a ser executado.
        // Raramente é utilizado, e serve para garantir funcionamentos que previamente foram executados no update. (casos especificos)
        // Exemplo: Sistema de camera seguir o personagem.
    }
    #endregion

    #region Finalização
    private void OnDisable()
    {
        // Chamado todas as vezes que o objeto for desativado em cena.
        // Geralmente utilizado para resetar valores ou simplesmente chamar eventos relacionados.
        // Exemplo: Com a morte do inimigo, retire 1 do total de inimigos em cena.
        // (Ex: Manager.enemyAmount--;)
    }

    private void OnDestroy()
    {
        // Chamado assim que o objeto for destruído, e portanto, uma única vez. É o ultimo meto a ser chamado.
        // Age semelhante ao OnDisable, e geralmente é utilizado quando deseja que um comportamento seja realizado ao destruir o objeto.
        // (Dependendo da estrutura do jogo, utilizará só OnDisable ou OnDestroy)
        // Exemplo: Adicionar pontuação ao jogador.
        // (EX: Manager.score += 50;)
    }
    #endregion
}

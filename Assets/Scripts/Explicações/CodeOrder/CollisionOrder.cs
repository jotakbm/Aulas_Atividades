using UnityEngine;

public class CollisionOrder : MonoBehaviour
{

    // No sistema de colisão da Unity, todos os metodos de uma colisão "Trigger" são chamados antes dos de uma colisão "Collision".
    // Trigger é a colisão sem física aplicada. Sendo assim, é possivel atravessar essa colisão, mas ainda sim saber que ela existiu.
    // Exemplo: Uma área que causa dano ou cura o jogador.
    #region Trigger
    private void OnTriggerEnter(Collider other)
    {
        // É chamada assim que a colisão inicia, sendo a primeira de todas a ser chamada.
    }

    private void OnTriggerStay(Collider other)
    {
        // É chamada em todos os frames em quanto a colisão estiver ocorrendo.
    }

    private void OnTriggerExit(Collider other)
    {
        // É chamada assim que os objetos deixam de se colidir, sendo o ultimo a ser chamado.
    }
    #endregion

    // No sistema de colisão da Unity, o uma colisão "Collision" é chamada após todos os metodos da colisão "Trigger".
    // Collision é a colisão com física aplicada. Sendo assim, não é possivel atravessa-la.
    // Exemplo: Uma parede, o chão, outro personagem.
    #region Collision
    private void OnCollisionEnter(Collision collision)
    {
        // É chamada assim que a colisão inicia, sendo a primeira de todas a ser chamada.
    }

    private void OnCollisionStay(Collision collision)
    {
        // É chamada em todos os frames em quanto a colisão estiver ocorrendo.
    }

    private void OnCollisionExit(Collision collision)
    {
        // É chamada assim que os objetos deixam de se colidir, sendo o ultimo a ser chamado.
    }
    #endregion
}

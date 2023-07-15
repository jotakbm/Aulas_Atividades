using UnityEngine;

public class CollisionOrder : MonoBehaviour
{

    // No sistema de colis�o da Unity, todos os metodos de uma colis�o "Trigger" s�o chamados antes dos de uma colis�o "Collision".
    // Trigger � a colis�o sem f�sica aplicada. Sendo assim, � possivel atravessar essa colis�o, mas ainda sim saber que ela existiu.
    // Exemplo: Uma �rea que causa dano ou cura o jogador.
    #region Trigger
    private void OnTriggerEnter(Collider other)
    {
        // � chamada assim que a colis�o inicia, sendo a primeira de todas a ser chamada.
    }

    private void OnTriggerStay(Collider other)
    {
        // � chamada em todos os frames em quanto a colis�o estiver ocorrendo.
    }

    private void OnTriggerExit(Collider other)
    {
        // � chamada assim que os objetos deixam de se colidir, sendo o ultimo a ser chamado.
    }
    #endregion

    // No sistema de colis�o da Unity, o uma colis�o "Collision" � chamada ap�s todos os metodos da colis�o "Trigger".
    // Collision � a colis�o com f�sica aplicada. Sendo assim, n�o � possivel atravessa-la.
    // Exemplo: Uma parede, o ch�o, outro personagem.
    #region Collision
    private void OnCollisionEnter(Collision collision)
    {
        // � chamada assim que a colis�o inicia, sendo a primeira de todas a ser chamada.
    }

    private void OnCollisionStay(Collision collision)
    {
        // � chamada em todos os frames em quanto a colis�o estiver ocorrendo.
    }

    private void OnCollisionExit(Collision collision)
    {
        // � chamada assim que os objetos deixam de se colidir, sendo o ultimo a ser chamado.
    }
    #endregion
}

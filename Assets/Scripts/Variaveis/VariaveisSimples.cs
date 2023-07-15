using UnityEngine;

public class AtividadeTiposDeVariaveis : MonoBehaviour
{
    // Valores de L�gica (Verdadeiro/Falso)
    public bool valorDeCondicao = true;

    // Valores de texto
    public string valoDeTexto = "Roberto";
    public char valoDeLetra = 'S';

    // Valores num�ricos
    public int valorInteiro = 100;
    public float valorComVirgula = 4.123456f;

    // Referencia a outras classes. � necess�rrio para acessar ou modificar seus valores e metodos.
    public ClasseExemplo instanciaDeClasse01;
    public ClasseExemplo instanciaDeClasse02;
    public ClasseExemplo instanciaDeClasse03;
    public ClasseExemplo instanciaDeClasse04;
    public ClasseExemplo instanciaDeClasse05;
}

public class ClasseExemplo
{

}
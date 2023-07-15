using UnityEngine;

// Para saber mais, acesse:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
public class VariaveisPrimitivasCompleto : MonoBehaviour
{
    #region Inteiro
    // Valor de -128 até 127.
    public sbyte valorInteiroByte;

    // Valor de 0 a 255.
    public byte valorInteiroBytePositivo;

    // Valor de -32,768 a 32,767.
    public short valorInteiroCurto;

    // Valor de 0 a 65,535.
    public ushort valorInteiroCurtoPositivo;

    // Valor mais usado. Valor de -2,147,483,648 a 2,147,483,647
    public int valoInteiro;

    // Valor de 0 a 4,294,967,295
    public uint valoInteiroPositivo;

    // Valor de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
    public long valorInteiroLongo;

    // Valor de 0 a 18,446,744,073,709,551,615
    public ulong valorInteiroLongoPositivo;
    #endregion

    #region Floating
    // Valor de ±1.5 x 10−45 a ±3.4 x 1038
    // Precisão de 6-9 digitos.
    // Valor mais usado. É necessário adicionar ao final do numero a letrar "f" para o compilador saber que é um float.
    public float valorFloat = 1.123456f;

    // Valor de ±5.0 × 10−324 a ±1.7 × 10308
    // Precisão de 15-17 digitos.
    // Pode ser adicionado ao final do numero a letrar "d" para o compilador saber que é um double, mas não é necessário.
    public double valorDouble = 1.123456789012345d;

    // Valor de ±1.0 x 10-28 a ±7.9228 x 1028
    // Precisão de 28-29 digitos.
    // É necessário adicionar ao final do numero a letrar "m" para o compilador saber que é um decimal.
    public decimal valoDecimal = 1.1234567890123456789012345678m;
    #endregion

    #region Logic
    // Verdadeiro ou falso. (true, false)
    public bool verdadeiro = true;
    #endregion

    #region Text
    // Grava textos. Utiliza aspas duplas para saber que é uma string.
    public string valoDeTexto = "Roberto";
    // Grava um único caracter. Utiliza aspas simples para saber que é um caracter.
    public char valoDeLetra = 'S';
    #endregion
}
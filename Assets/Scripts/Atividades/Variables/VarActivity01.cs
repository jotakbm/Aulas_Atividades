using System.Collections.Generic;
using UnityEngine;

namespace Atividades.Variables01
{
    // 1 - Coloque um valor inicial em cada uma das variaveis.
    // 2 - Ao lado de cada uma das variaveis, comente se essa variavel é: [Primitiva] ou [Não Primitiva]
    public class VarActivity01 : MonoBehaviour
    {
        public bool valorDeCondicao;

        public string valoDeTexto;
        public char valoDeLetra;

        public int valorInteiro;
        public float valorComVirgula;

        public byte valorInteiroBytePositivo;
        public double valorDouble;
        public decimal valoDecimal;

        public int[] arrayDeInteiros;
        public List<float> listaDeFloats;

        public Vector2 vetor2;
        public Vector3 Vector3;
        public Quaternion quaternion;

        public ClasseExemplo instanciaDeClasse01;
        public EnumExemplo enumExemplo;
    }

    public class ClasseExemplo
    {

    }

    public struct StructExemplo
    {

    }

    public enum EnumExemplo
    {
        Valor1,
        Valor2,
        Valor3
    }
}
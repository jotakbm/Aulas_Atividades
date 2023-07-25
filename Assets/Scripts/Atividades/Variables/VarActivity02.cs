using System.Collections.Generic;
using UnityEngine;

namespace Atividades.Variables02
{
    public class ValueActivity01 : MonoBehaviour
    {
        public int valor01 = 1;
        public int valor02 = 2;
    }

    // Defina o tipo de cada coisa: [Variavel (comum, parametro, variavel local)], [Propriedade], [Metodo], [Classe], [Struct]
    public class VarActivity02 : MonoBehaviour
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
        public CustomVector3 vetor3Customizado;
        public Quaternion quaternion;

        public ExemploVazio instanciaDeClasse01;
        public Valores enumExemplo;
        public Numbers123 numeros123;

        public int ValorInteiro { get => valorInteiro; set => valorInteiro = value; }
        public int ValorFloat { get; set; }

        [System.Serializable]
        public struct CustomVector3
        {
            public int valor01;
            public int valor02;
            public int valor03;

            public CustomVector3(int valor01, int valor02, int valor03)
            {
                this.valor01 = valor01;
                this.valor02 = valor02;
                this.valor03 = valor03;
            }
        }

        public enum Numbers123
        {
            Number01 = 1,
            Number02 = 2,
            Number03 = 3
        }

        public float MultiplyNumbers(float valor1, float valor2)
        {
            float finalValue = valor1 * valor2;
            return finalValue;
        }

        public bool IsPositiveNumber(float numero)
        {
            bool isPositive = numero >= 0;
            return isPositive;
        }

        public void TakeDamage(float damage, bool isCritical, string criticalText = "Critical!")
        {
            int armor = 5;
            float resistance = 0.2f;
            float finalDamage = (damage - armor) * (1 - resistance);

            if (isCritical)
            {
                float damageMultiplier = 2;
                finalDamage *= damageMultiplier;
                Debug.Log($"{finalDamage}");
            }
            else
            {
                Debug.Log($"{criticalText}: {finalDamage}");
            }
        }
    }

    public class ExemploVazio
    {

    }

    public struct OutroExemplo
    {

    }

    public enum Valores
    {
        Valor1 = 0,
        Valor2 = 5,
        Valor3 = 99
    }
}
using UnityEngine;

namespace Atividades.MethodsResults01
{
    // Escreva qual seria o resultado mostrado no Debug ao executar cada um dos metodos a seguir:
    public class MethodsResults : MonoBehaviour
    {
        #region Atividade 01
        public void Method01()
        {
            Debug.Log("TextoExemplo");
        }
        #endregion

        #region Atividade 02
        public void Method02()
        {
            string text = "Um Texto!";
            Debug.Log(text);
        }
        #endregion

        #region Atividade 03
        public void Method03()
        {
            string text = "Texto";
            string text02 = "Incrivel";

            Debug.Log(text02);
        }
        #endregion

        #region Atividade 04
        public void Method04()
        {
            string text = "Texto";
            string text02 = "Incrivel";

            Debug.Log(text + text02);
        }
        #endregion

        #region Atividade 05
        public void Method05()
        {
            string text = "Texto";
            string text02 = "Incrivel";

            Debug.Log($"{text} {text02} Inovador!");
        }
        #endregion

        #region Atividade 06
        public void Method06()
        {
            float valor01 = 2;
            float valor02 = 5;
            float valor03 = 3;

            float resultado = valor01 + valor02 * valor03;
            Debug.Log(resultado);
        }
        #endregion

        #region Atividade 07
        public void Method07()
        {
            string texto = "Texto";
            return;
            Debug.Log(texto);
        }
        #endregion

        #region Atividade 08
        public void Method08()
        {
            string valor01 = "Valores:";
            int valor02 = 5;
            bool valor03 = true;

            string textoResultado = $"{valor01} {valor02}, {valor03}" + " - " + "false";
            Debug.Log(textoResultado);
        }
        #endregion

        #region Atividade 09
        public void Method09()
        {
            float someValue = -1;
            someValue = GetValuePlusTwo(someValue);

            if (CheckIfValueIsPositive(someValue))
            {
                Debug.Log("IsPositive");
            }

            if (CheckIfValueIsZero(someValue))
            {
                Debug.Log("IsZero");
            }

            if (CheckIfValueIsNegative(someValue))
            {
                Debug.Log("IsNegative");
            }
        }

        private float GetValuePlusTwo(float value)
        {
            return value + 2;
        }

        private bool CheckIfValueIsPositive(float value)
        {
            return value > 0;
        }

        private bool CheckIfValueIsZero(float value)
        {
            return value == 0;
        }

        private bool CheckIfValueIsNegative(float value)
        {
            return value < 0;
        }
        #endregion

        #region Atividade 10
        public void Method10()
        {
            int valor01 = 1;
            Debug.Log(valor01.ToString("000"));
        }
        #endregion

        #region Atividade 11
        public void Method11()
        {
            Debug.Log(1 + 2 * 2 / 3);
        }
        #endregion

        #region Atividade 12
        public void Method12()
        {
            bool booleana = 5 > 3;
            string texto = booleana ? "Azul" : "Verde";
            Debug.Log(texto);
        }
        #endregion

        #region Atividade 13
        public void Method13()
        {
            string texto = "<color=red><b>Texto Especial</b></color>";
            Debug.Log(texto);
        }
        #endregion

        #region Atividade 14
        public void Method14()
        {
            string texto = "Texto".ToString();
            Debug.Log(texto);
        }
        #endregion

        #region Atividade 15
        public void Method15()
        {
            string texto = null;
            Debug.Log(texto);
        }
        #endregion

        #region Atividade 16
        public void Method16()
        {
            int valor = 10;
            if (valor > 5)
            {
                Debug.Log("Valor é maior que 5");
            }
            else
            {
                Debug.Log("Valor não é maior que 5");
            }
        }
        #endregion

        #region Atividade 17
        public void Method17()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            foreach (int numero in numeros)
            {
                Debug.Log(numero);
            }
        }
        #endregion

        #region Atividade 18
        public void Method18()
        {
            int contador = 0;
            while (contador < 5)
            {
                Debug.Log("Contador: " + contador);
                contador++;
            }
        }
        #endregion

        #region Atividade 19
        public void Method19()
        {
            int valor = 5;
            switch (valor)
            {
                case 1:
                    Debug.Log("Valor é 1");
                    break;
                case 2:
                    Debug.Log("Valor é 2");
                    break;
                case 3:
                    Debug.Log("Valor é 3");
                    break;
                default:
                    Debug.Log("Valor não é 1, 2 ou 3");
                    break;
            }
        }
        #endregion

        #region Atividade 20
        public void Method20()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            Debug.Log("Soma: " + soma);
        }
        #endregion

        #region Prova01
        // 1 - Responda qual, ou quais (caso haja mais de um) valores de Debug apareceriam caso o código abaixo fosse executado no Start.
        [ContextMenu("Exam")]
        public void Exam01()
        {
            int valor1 = 1;
            int valor2 = 2;
            bool valorBolleano1 = false;
            bool valorBolleano2 = true;
            string casoNumero = "";
            string casoLetra;

            if (casoNumero == null)
            {
                Debug.Log("Texto nulo. Fim de operação!");
                return;
            }

            valor1 *= 2;
            valor2 /= 1;
            int valorSoma = (4 + (valor1 += 5 + ++valor2) + valor2++ * 2) / 2;

            if (valorSoma == 12)
            {
                Debug.Log("Valor igual a 12. Fim de operação!");
                return;
            }

            if (valor1 > valor2 * 3)
            {
                casoNumero = "01";
                if (valorBolleano1 && valorBolleano2)
                {
                    casoLetra = "A";
                }
                else if (valorBolleano1 || valorBolleano2)
                {
                    casoLetra = "B";
                }
                else
                {
                    casoLetra = "C";
                }
            }
            else if (valor1 < valor2)
            {
                casoNumero = "02";
                if (valorBolleano1 && valorBolleano2)
                {
                    casoLetra = "A";
                }
                else if (valorBolleano1 || valorBolleano2)
                {
                    casoLetra = "B";
                }
                else
                {
                    casoLetra = "C";
                }
            }
            else
            {
                casoNumero = "03";
                if (valorBolleano1 && valorBolleano2)
                {
                    casoLetra = "A";
                }
                else if (valorBolleano1 || valorBolleano2)
                {
                    casoLetra = "B";
                }
                else
                {
                    casoLetra = "C";
                }
            }

            if (valorBolleano1 && valorBolleano2 || (valor1 < valor2 && valor2 > 5) || !valorBolleano1 || (4 * 2.5f < 3 * 3))
            {
                if (casoNumero == "01")
                {
                    Debug.Log($"Caso{casoNumero}.Tipo01[{valorSoma}]");
                }
                else if (casoNumero != string.Empty)
                {
                    Debug.Log($"Caso{casoNumero}.{casoLetra}" + "[" + valorSoma + "]");
                }
                else
                {
                    Debug.Log($"Caso{casoNumero}.Tipo02" + ": " + casoLetra + $"[{valorSoma}]");
                }
            }
            else
            {
                Debug.Log($"Nenhum caso correto");
            }
        }
        #endregion
    }
}
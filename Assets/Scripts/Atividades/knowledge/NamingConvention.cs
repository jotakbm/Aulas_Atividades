using UnityEngine;

namespace Atividades.NamingConvention01
{
    public class NamingConvention : MonoBehaviour
    {
        // 1 - Qual o formato convencional de nomeclatura de variaveis e metodos no C#?
        // R:

        // 2 - Por que existe essa convenção? Por que ela é util na programaçao?
        // R:

        // 3 - Nao usar essa convenção pode gerar ERROS no seu projeto? Ou é algo apenas estético?
        // R:

        // 4 - Escreva o que cada parte representa na composiçao dos seguintes casos:

        // 4.1 - Variavel
        // [NomeDaParte] [NomeDaParte] [NomeDaParte] = [NomeDaParte]
        public string textoIncrivel = "Olá";

        // 4.2 - Metodo
        // [NomeDaParte] [NomeDaParte] [NomeDaParte]([NomeDaParte])
        private void Metodo01(string textoQualquer)
        {

        }

        // 4.3 - Classe
        // [NomeDaParte] [NomeDaParte] [NomeDaParte] : [NomeDaParte], [NomeDaParte]
        public class ExampleClass : MonoBehaviour, IExampleInterface
        {

        }

        // 4.4 - Struct
        // [NomeDaParte] [NomeDaParte] [NomeDaParte]
        public struct ExampleStruct
        {

        }

        // 4.5 - Interface
        // [NomeDaParte] [NomeDaParte] [NomeDaParte]
        public interface IExampleInterface
        {

        }

        // 4.6 - Enum
        // [NomeDaParte] [NomeDaParte] [NomeDaParte]
        public enum ExampleEnum
        {

        }
    }
}
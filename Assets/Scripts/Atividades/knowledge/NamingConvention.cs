using UnityEngine;

namespace Atividades.NamingConvention01
{
    public class NamingConvention : MonoBehaviour
    {
        // 1 - Qual o formato convencional de nomeclatura de variaveis e metodos no C#?
        // R:

        // 2 - Por que existe essa conven��o? Por que ela � util na programa�ao?
        // R:

        // 3 - Nao usar essa conven��o pode gerar ERROS no seu projeto? Ou � algo apenas est�tico?
        // R:

        // 4 - Escreva o que cada parte representa na composi�ao dos seguintes casos:

        // 4.1 - Variavel
        // [NomeDaParte] [NomeDaParte] [NomeDaParte] = [NomeDaParte]
        public string textoIncrivel = "Ol�";

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
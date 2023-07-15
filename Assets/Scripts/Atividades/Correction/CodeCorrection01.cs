//using UnityEngine;

//// Para este exercicio, você deverá corrigir todos os erros do projeto
//// Exemplo: erros ortograficos, erros de lógica ou qualquer erro que impeça o projeto de funcionar corretamente.
//// Lembre-se de quem deve usar camelCase, ou PascalCase
//// Lembre-se de corrigir acessores (como public ou private quando estiverem incorretos ou desnecessarios)

//public class exercicio01 : MonoBehaviour
//{
//    public ExemploVazio exemplo = new ExemploVazio();

//    private void Start()
//    {
//        // Se o valor flutuante for maior que o valor inteiro, chame o debug para saber o valor de "valorString"
//        if (exemplo.ValorFlutuante > exemplo.valorInteiro)
//        {
//            debug.log(valorString);
//        }

//        //Faça o "MensagemSecreta()" funcioNar corrigindo o que for necessário
//        if (exemplo.chequeValorMenorQueZero())
//        {
//            ExemploVazio.MensagemSecreta(5);
//        }
//    }
//}

//public class ExemploVazio
//{
//    public float ValorFlutuante = 5.1;
//    private bool ValorBooleano = true;
//    protected Int valorInteiro = 2.5f;
//    public string valorString = "Teste";
//    public string mensagemSecreta = "Incrivel!";

//    // Se for menor que zero, retorne verdadeiro
//    private Bool chequeValorMenorQueZero(int valor)
//    {
//        return valor > 0;
//    }

//    public void MensagemSecreta()
//    {
//        Debug.Log(mensagemSecreta);
//    }
//}
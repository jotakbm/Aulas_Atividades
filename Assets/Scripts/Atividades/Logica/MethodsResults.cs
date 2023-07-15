using UnityEngine;

public class MethodsResults : MonoBehaviour
{
    public void Method01()
    {
        Debug.Log("TextoExemplo");
    }

    public void Method02()
    {
        string text = "Um Texto!";
        Debug.Log(text);
    }

    public void Method03()
    {
        string text = "Texto";
        string text02 = "Incrivel";

        Debug.Log(text02);
    }

    public void Method04()
    {
        string text = "Texto";
        string text02 = "Incrivel";

        Debug.Log(text + text02);
    }

    public void Method05()
    {
        string text = "Texto";
        string text02 = "Incrivel";

        Debug.Log($"{text} {text02} Inovador!");
    }

    public void Method06()
    {
        float valor01 = 2;
        float valor02 = 5;
        float valor03 = 3;

        float resultado = valor01 + valor02 * valor03;
        Debug.Log(resultado);
    }

    public void Method07()
    {
        float valor01 = 2;
        float valor02 = 5;
        float valor03 = 3;

        float resultado = valor01 + valor02 * valor03;
        Debug.Log(resultado);
    }

    public void Method08()
    {
        string valor01 = "Valores:";
        int valor02 = 5;
        bool valor03 = true;

        string textoResultado = $"{valor01} {valor02}, {valor03}" + " - " + "false";
        Debug.Log(textoResultado);
    }

    public void Method09()
    {

    }

    public void Method10()
    {

    }

    public void Method11()
    {

    }

    public void Method12()
    {

    }
}
using UnityEngine;

public class ExemploMetodos : MonoBehaviour
{
    [SerializeField] private float someValue = 5;
    private void Start()
    {
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
}
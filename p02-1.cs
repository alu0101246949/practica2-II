using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomArrayScript : MonoBehaviour
{
    public int arrayLength = 10; // Longitud del array. Ajustable desde el Inspector.
    public int minValue = 0;    // Valor mínimo del rango. Ajustable desde el Inspector.
    public int maxValue = 25;   // Valor máximo del rango. Ajustable desde el Inspector.
    public int threshold = 15;  // Umbral para mostrar valores en la consola. Ajustable desde el Inspector.

    private int[] numbers;

    void Start()
    {
        // Inicializar el array
        numbers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = Random.Range(minValue, maxValue + 1); // +1 porque Random.Range excluye el valor máximo cuando se trabaja con int
        }
    }

    void Update()
    {
        // Cambiar un valor aleatorio
        int randomIndex = Random.Range(0, arrayLength);
        numbers[randomIndex] = Random.Range(minValue, maxValue + 1);

        // Mostrar valores mayores que el umbral
        foreach (int num in numbers)
        {
            if (num > threshold)
            {
                Debug.Log(num);
            }
        }
    }
}

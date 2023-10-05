using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColorOnKeyPress : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;

    void Update()
    {
        // Verificar si las referencias al cubo y cilindro están establecidas
        if (cube == null || cylinder == null)
        {
            Debug.LogError("Cube and/or Cylinder references are not set.");
            return;
        }

        // Cambiar el color del cilindro cuando se presiona la tecla A
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeColor(cylinder, Color.red); // Cambia el color del cilindro a rojo
        }

        // Cambiar el color del cubo cuando se presiona la tecla de flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeColor(cube, Color.blue); // Cambia el color del cubo a azul
        }
    }

    void ChangeColor(GameObject obj, Color newColor)
    {
        // Obtener el Renderer del objeto y cambiar el color de su material
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null) // Verificar si el renderer es no nulo
        {
            renderer.material.color = newColor;
        }
        else
        {
            Debug.LogError("No Renderer component found on " + obj.name);
        }
    }
}

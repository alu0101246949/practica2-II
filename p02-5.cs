using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DistanceToSphere : MonoBehaviour
{
    public string sphereTag = "blue_sphere"; // Etiqueta del objeto esfera

    void Start()
    {
        // Encontrar la esfera utilizando su etiqueta
        GameObject sphere = GameObject.FindWithTag(sphereTag);

        // Verificar si el objeto esfera fue encontrado
        if (sphere != null)
        {
            // Calcular y mostrar la distancia a la esfera
            float distance = Vector3.Distance(transform.position, sphere.transform.position);
            Debug.Log("Distance from " + gameObject.name + " to Sphere: " + distance);
        }
        else
        {
            Debug.LogError("Object with tag " + sphereTag + " not found.");
        }
    }
}

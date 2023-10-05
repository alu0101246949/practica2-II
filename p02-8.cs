using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    public GameObject cube;
    private GameObject nearestSphere;
    private GameObject farthestSphere;

    void Start()
    {
        if (cube == null)
        {
            Debug.LogError("Cube reference not set.");
            return;
        }

        // Recupera todas las esferas con la etiqueta "Grupo 2"
        GameObject[] group2Spheres = GameObject.FindGameObjectsWithTag("Grupo 2");
        if (group2Spheres.Length == 0)
        {
            Debug.LogError("No spheres found with tag Grupo 2.");
            return;
        }

        // Valores iniciales para las distancias
        float minDistance = float.MaxValue;
        float maxDistance = float.MinValue;

        foreach (GameObject sphere in group2Spheres)
        {
            float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                nearestSphere = sphere;
            }
            if (distance > maxDistance)
            {
                maxDistance = distance;
                farthestSphere = sphere;
            }
        }

        // Subir la esfera más cercana
        Vector3 newPosition = nearestSphere.transform.position;
        newPosition.y += 5.0f;  // Aumenta la altura en 5 unidades
        nearestSphere.transform.position = newPosition;
    }

    void Update()
    {
        // Cambiar el color de la esfera más lejana cuando se presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space) && farthestSphere != null)
        {
            Renderer renderer = farthestSphere.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.green;  // Cambia el color a verde, por ejemplo
            }
        }
    }
}

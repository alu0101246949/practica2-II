using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AlignObjects : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;

    void Update()
    {
        // Si la esfera, el cilindro y el cubo están asignados en el Inspector
        if (cube != null && cylinder != null)
        {
            // Posición de la esfera
            Vector3 spherePosition = transform.position;

            // Alinear el cubo y el cilindro en el eje Y y Z de la esfera
            cube.transform.position = new Vector3(spherePosition.x - 5, spherePosition.y, spherePosition.z);
            cylinder.transform.position = new Vector3(spherePosition.x + 5, spherePosition.y, spherePosition.z);
        }
    }
}

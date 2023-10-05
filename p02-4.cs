using UnityEngine;

public class MostrarPosicionEsfera : MonoBehaviour
{
    private Transform esferaTransform;

    private void Start()
    {
        // Obtén la referencia al componente Transform de la esfera
        esferaTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        // Muestra la posición de la esfera en la consola
        Debug.Log("Posición de la esfera: " + esferaTransform.position);
    }
}

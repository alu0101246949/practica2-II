using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class SphereVectorScript : MonoBehaviour
{
    [Header("Input Vectors")]
    public Vector3 vector1 = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vector2 = new Vector3(0.0f, 1.0f, 0.0f);

    [Header("Results")]
    [SerializeField]
    private float magnitudeVector1;

    [SerializeField]
    private float magnitudeVector2;

    [SerializeField]
    private float angleBetweenVectors;

    [SerializeField]
    private float distanceBetweenVectors;

    [SerializeField]
    private string higherVectorMessage;

    private void Update()
    {
        // Calculating magnitudes
        magnitudeVector1 = vector1.magnitude;
        magnitudeVector2 = vector2.magnitude;

        // Calculating angle between vectors in degrees
        angleBetweenVectors = Vector3.Angle(vector1, vector2);

        // Calculating distance between vectors (treated as points in space)
        distanceBetweenVectors = Vector3.Distance(vector1, vector2);

        // Determining which vector is at a greater height
        if (vector1.y > vector2.y)
        {
            higherVectorMessage = "Vector1 is at a greater height.";
        }
        else if (vector1.y < vector2.y)
        {
            higherVectorMessage = "Vector2 is at a greater height.";
        }
        else
        {
            higherVectorMessage = "Both vectors are at the same height.";
        }

        // Logging to Console
        Debug.Log($"Magnitude Vector1: {magnitudeVector1}");
        Debug.Log($"Magnitude Vector2: {magnitudeVector2}");
        Debug.Log($"Angle Between Vectors: {angleBetweenVectors} degrees");
        Debug.Log($"Distance Between Vectors: {distanceBetweenVectors}");
        Debug.Log(higherVectorMessage);
    }
}

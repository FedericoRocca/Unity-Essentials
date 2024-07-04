using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Speed of rotation in degrees per second
    public float rotationSpeed = 1.0f;

    void Update()
    {
        // Calculate the rotation angle based on time
        float rotationAngle = Time.deltaTime * rotationSpeed;

        // Rotate the directional light around the Y-axis
        transform.Rotate(Vector3.up, rotationAngle);
    }
}
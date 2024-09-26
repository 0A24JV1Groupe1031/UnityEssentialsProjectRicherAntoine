using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The time in seconds for a full day to pass
    [SerializeField]
    private float dayDuration = 120f; // Default is 120 seconds (2 minutes)

    // Variable to track the rotation speed
    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the day duration
        rotationSpeed = 360f / dayDuration; // 360 degrees in a full rotation
    }

    void Update()
    {
        // Calculate the rotation angle based on time
        float angle = rotationSpeed * Time.deltaTime;

        // Rotate the light around the X axis (adjust as needed)
        transform.Rotate(angle, 0f, 0f);
    }
}
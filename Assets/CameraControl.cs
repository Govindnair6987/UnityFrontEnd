using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target; // The target to follow (the NavMesh agent)
    public float distance = 7.0f; // The distance between the camera and the target
    public float height = 1.0f; // The height of the camera above the target
    public float smoothSpeed = 0.125f; // The speed at which the camera moves

    private Vector3 velocity = Vector3.zero; // The current velocity of the camera

    void FixedUpdate()
    {
        // Calculate the position the camera should be at
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;

        // Move the camera towards the target position smoothly
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);

        // Make the camera look at the target
        transform.LookAt(target);
    }
}

using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    [SerializeField]
    Vector3 offset;
    [SerializeField]
    float smoothspeed = 0.25f;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,smoothspeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

}

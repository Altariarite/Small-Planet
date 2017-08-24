using UnityEngine;

public class PlanetMovement : MonoBehaviour {

    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    void FixedUpdate()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * -tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}   

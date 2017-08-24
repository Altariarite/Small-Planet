using UnityEngine;

public class PlanetMovement : MonoBehaviour {

    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    void Update()
    {
        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");
        float tiltAroundZ = z * -tiltAngle;
        float tiltAroundX = x * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}   

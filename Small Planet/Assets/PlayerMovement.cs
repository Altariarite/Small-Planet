using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerRigidbody;
    Vector3 movement;

    [SerializeField]
    float force;

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        

        Move(h, v);

    }
    void Move(float h, float v)
    {
        playerRigidbody.AddForce(h*force*Time.deltaTime, 0, v*force*Time.deltaTime,ForceMode.VelocityChange); 
    }

}

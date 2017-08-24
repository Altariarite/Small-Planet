using UnityEngine;

public class Attraction : MonoBehaviour {

    public Rigidbody rb;
    public Transform target;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
    Vector3 force = target.position-transform.position;
        rb.AddForce(force,ForceMode.Force);
	}
}

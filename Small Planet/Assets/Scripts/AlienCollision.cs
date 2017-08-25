using UnityEngine;

public class AlienCollision : MonoBehaviour {

    public GameObject obj;
    public GameObject spawn;
    [SerializeField]
    float lapse;

   void OnCollisionEnter(Collision collision)
    {
        //ContactPoint contact = collision.contacts[0];
        //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        //Vector3 pos = contact.point;
        GameObject clone = Instantiate(spawn, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(clone, lapse);
    }
}

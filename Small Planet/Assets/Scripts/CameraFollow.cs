using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    [SerializeField]
    Vector3 offset;
    private void Start()
    {
        transform.position = offset;
    }
    

    private void Update()
    {
        
        transform.LookAt(target);
    }

}

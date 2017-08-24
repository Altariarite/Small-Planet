using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    public GameObject Meteor;

    [SerializeField]
    float height;
    [SerializeField]
    float size;
    [SerializeField]
    float spawntime;
    //[SerializeField]
    //float Radius;

    private void Start()
    {
        StartCoroutine(SpawnMeteor());
    }

    //SpawnMeteor from the top
    IEnumerator SpawnMeteor()
    {
        Vector3 pos = new Vector3(Random.Range(-size, size), height, Random.Range(-size, size));
        //Vector3 pos = Random.onUnitSphere * Radius;
        Instantiate(Meteor,pos,transform.rotation);

        yield return new WaitForSeconds(spawntime);

        StartCoroutine(SpawnMeteor());

    }
}
 
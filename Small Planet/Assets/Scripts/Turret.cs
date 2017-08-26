using UnityEngine;

public class Turret : MonoBehaviour {

    private Transform target;

    public string enemyTag = "Enemy";
    
    [Header("Unity Setup")]
    public Transform partToRotate;
    public float turnspeed = 1f;

    [Header("Attributes")]
    public float range = 15f;
    public float fireRate = 1f;
    public float fireCountdown = 0f;


	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    
	}
	
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies)//Turret range
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
        
    }
	// Update is called once per frame
	void Update () {
        if (target == null)
            return;

        //Target lock on
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime*turnspeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(rotation);


        if (fireCountdown <= 0f)
        {
            Shoot();
          
        }
	}

    void Shoot ()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,range);

    }
}

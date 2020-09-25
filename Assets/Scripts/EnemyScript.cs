using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public GameObject enemyProjectile;
        
    // Start is called before the first frame update
    void Start()
    {
        float delay = Random.Range(2f, 10f);
        float rate = Random.Range(2f, 8f);
        InvokeRepeating("Fire", delay, rate);   
    }

    private void Fire()
    {
        int chance = Random.Range(1, 5);
        if (chance > 3)
        {
            Instantiate(enemyProjectile, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}

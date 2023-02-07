using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject cylinderEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 1.0f, 1.0f);
    }

    void spawnEnemy() {
        Instantiate(cylinderEnemy, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

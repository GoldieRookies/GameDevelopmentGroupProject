using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkIfDead();
    }
    void checkIfDead() {
        if(health <= 0) {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy") {
            takeDamage(1);
        }
        if(other.gameObject.tag == "EnemyBullet") {
            takeDamage(1);
        }
    }


    public void takeDamage(float damage) {
        health -= damage;
    }
}

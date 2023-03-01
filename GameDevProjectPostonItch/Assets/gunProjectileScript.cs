using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunProjectileScript : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public GameObject emptyWhereGunWillSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("launchProjectile", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Rigidbody rigidbodyBulletComponent;
    GameObject instantiatedBullet;
    void launchProjectile() {
        instantiatedBullet = Instantiate(bullet, emptyWhereGunWillSpawn.transform.position, emptyWhereGunWillSpawn.transform.rotation);
        rigidbodyBulletComponent = instantiatedBullet.GetComponent<Rigidbody>();
        rigidbodyBulletComponent.AddForce(transform.forward * bulletSpeed);
    }
}

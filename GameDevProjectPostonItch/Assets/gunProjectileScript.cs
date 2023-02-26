using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunProjectileScript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("launchProjectile", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void launchProjectile() {
        Instantiate(bullet);
    }
}

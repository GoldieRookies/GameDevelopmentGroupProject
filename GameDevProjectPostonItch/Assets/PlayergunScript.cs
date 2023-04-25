using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayergunScript : MonoBehaviour
{
    public GameObject bullet;
    
    public GameObject gunShotGo;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Rigidbody rigidBullet;
    GameObject instantiatedBullet;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            
            instantiatedBullet = Instantiate(bullet, gunShotGo.transform.position, gunShotGo.transform.rotation);
            rigidBullet =  instantiatedBullet.GetComponent<Rigidbody>();
            rigidBullet.tag = "PlayerBullet";
            rigidBullet.AddForce(transform.forward * bulletSpeed);
        } 
    }
}

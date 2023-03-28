using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float speedOfRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        /*Vector3 angleTarget = Vector3.RotateTowards(transform.position, player.transform.position, speedOfRotation * Time.deltaTime, 0.0f);

        transform.rotation = Quaternion.LookRotation(angleTarget);*/
    }

}

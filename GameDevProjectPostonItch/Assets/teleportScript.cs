using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour
{
    public Transform level2Start;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // in order for teleportation to work for player, you have to disable its movement first to make the object static
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.GetComponent<Collider>().tag == "Block") {
            Debug.Log("Hit the object");
            // change a position's object to another position
            other.gameObject.transform.position = level2Start.position + offset;
        }
    }
}

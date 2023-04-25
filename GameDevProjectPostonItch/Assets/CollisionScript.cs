using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        // if you want to create a collision script with all the tags of when the object collides, I think you need for loop
        if(other.gameObject.tag == "Player") {
            Debug.Log("Destroy object");
            Destroy(gameObject);
        }
        
    }
}

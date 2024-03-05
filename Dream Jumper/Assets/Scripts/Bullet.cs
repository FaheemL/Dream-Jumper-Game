using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        if(hitInfo.tag == "Enemy" || hitInfo.tag == "Real"){
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
        }
    }
}

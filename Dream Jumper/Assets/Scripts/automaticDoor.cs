using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automaticDoor : MonoBehaviour
{

    private Animator animator;
    
    bool DoorOpen = false;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Player"){
            DoorOpen = true;
            animator.SetBool("DoorOpen", DoorOpen);
        }
        
    }
    void OnTriggerExit2D(Collider2D col) {
        if(col.tag == "Player"){
            DoorOpen = false;
            animator.SetBool("DoorOpen", DoorOpen);
        }
        
    }
}

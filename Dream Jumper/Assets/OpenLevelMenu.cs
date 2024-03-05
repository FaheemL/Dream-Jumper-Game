using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLevelMenu : MonoBehaviour
{

    private Animator animator;
    
    bool OpenUI = false;
    
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
            OpenUI = true;
            animator.SetBool("OpenUI", OpenUI);
        }
        
    }
    void OnTriggerExit2D(Collider2D col) {
        if(col.tag == "Player"){
            OpenUI = false;
            animator.SetBool("OpenUI", OpenUI);
        }
        
    }
}

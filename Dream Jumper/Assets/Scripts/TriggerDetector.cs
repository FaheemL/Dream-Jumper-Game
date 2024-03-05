using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{   
    public PlayerController Player;
    public int jumpsOnTouch;
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.tag == "Real"){
             Player.editJumpCount(jumpsOnTouch);
             Debug.Log(collision.name);
             Debug.Log(jumpsOnTouch);
        }
    }

}

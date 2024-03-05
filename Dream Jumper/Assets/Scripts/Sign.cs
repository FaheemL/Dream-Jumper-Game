using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public Gameover Text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") Text.SetUp();
    
    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.tag == "Player") Text.SetDown();
    
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   [SerializeField] private float speed = 2f;
   public PlayerStats Player;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision == Player.Hitbox())
        {
            Player.TakeDamage(10);


        }
    }
}

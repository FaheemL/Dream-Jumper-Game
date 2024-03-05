using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public PlayerStats Player;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other == Player.Hitbox())
        {
            Player.TakeDamage(5);
        }
        
    }
}

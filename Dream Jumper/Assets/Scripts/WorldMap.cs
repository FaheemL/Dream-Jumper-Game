using System.Xml.Schema;
using System.Net.Mail;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMap : MonoBehaviour
{
 public Renderer[] sprites;
    

    public void MoveSortingReal()
    {
        foreach( Renderer sprite in sprites)
        {
            UnityEngine.Debug.Log("Real Sprite");
            sprite.tag= "Real";   
        }
        
    }

    public void MoveSortingDream()
    {
         foreach( Renderer sprite in sprites)
        {
            UnityEngine.Debug.Log("Dream Sprite");
            sprite.tag = "Dream";   
        }
    }



}

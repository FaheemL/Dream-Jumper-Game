using System;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Text;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedWorldTrigger : MonoBehaviour
{
    public Camera RealCam;
    public PlayerController Player;
    public PlayerStats PlayerStats;
    public Boolean realWorld;
    public EnemyBehavior[] states;
    public Gameover complete;

    void Start()
    {
        RealCam.enabled = true;


        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (realWorld & (other == PlayerStats.Hitbox())) SwitchingWorld();
        //this is for setting end trigger for level
        else if (!realWorld & (other == PlayerStats.Hitbox()))
        {
            complete.SetUp();
            PlayerStats.EnergyBarsUpdate(1000);
        }
        
    }
    private void SwitchingWorld() 
    {
        realWorld = !realWorld;
        //move the player back to the start
        Player.Respawn();

        //switchs enemy sprite
        foreach( EnemyBehavior state in states) 
        {
            state.EditState(1);
        }
        //switch over energy
        PlayerStats.Flip();
        
    }

    public Boolean World()
    {
        return realWorld;
    }
}

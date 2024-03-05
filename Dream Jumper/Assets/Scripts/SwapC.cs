using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapC : MonoBehaviour
{
    public GameObject entity;
    public BedWorldTrigger bed;
    public Color DreamColour;
    public Tilemap rend;

    void Start(){

    }
    void Update() {
        if (!bed.World())
        {
            rend.color = DreamColour;
        }

    }
}

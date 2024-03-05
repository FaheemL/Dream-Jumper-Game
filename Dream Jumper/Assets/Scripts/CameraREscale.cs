using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraREscale : MonoBehaviour
{
    public BedWorldTrigger Bed;  
    public PlayerStats Player;
    public Camera RealCam; 
    private Vector3 change; 
    public float adjust;
    // Start is called before the first frame update
    void Start()
    {
        change.y = adjust;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!Bed.realWorld)
        {
            change.y = adjust;
            RealCam.orthographicSize = 5.529694f;
            transform.position = Player.transform.position + change;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCameraOperation : MonoBehaviour
{
    public BedWorldTrigger bed;
    public Camera dream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!bed.realWorld){
            dream.Render();
            UnityEngine.Debug.Log("Rendering...");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tracker
{
    static int previous;
    static int current;

    public static void NewPrevious(int updated) 
    {
        previous = updated;
        Debug.Log(Tracker.CallPrevious());
    }
    
    public static int CallPrevious()
    {
        return previous;
    }

    public static void NewCurrent(int updated) 
    {
        current = updated;
        Debug.Log(Tracker.CallCurrent());
    }

    public static int CallCurrent()
    {
        return current;
    }
}
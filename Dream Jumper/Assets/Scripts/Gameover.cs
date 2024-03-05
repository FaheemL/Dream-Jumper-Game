using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public void SetUp()
    {
        gameObject.SetActive(true);
    }

    public void SetDown()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTutorial : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Player"){
            SceneManager.LoadScene("Tutoral Level");
        }
    }
}
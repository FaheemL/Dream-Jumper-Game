using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMover : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
        
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
        
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
        
    }

    public void Gameover()
    {
        SceneManager.LoadScene("Gameover");
    }

    public void HubWorld()
    {
        SceneManager.LoadScene("Hub World");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void TutLevel()
    {
        SceneManager.LoadScene("Tutoral Level");
    }

}

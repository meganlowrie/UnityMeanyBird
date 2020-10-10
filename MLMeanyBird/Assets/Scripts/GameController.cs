using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game over canvas that is used for the game
    [Header("Game Over UI Object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    //Score Canvas that is used for the game
    [Header("Score UI Object for displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object that is used for the game
    [Header("Spawner Object for spawning objects in game")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        //Score in visible
        scoreCanvas.SetActive(true);
        //Game over UI is invisible
        gameOverCanvas.SetActive(false);
        //Spawner is visible in game
        spawner.SetActive(true);
    }

    public void GameOver(){
        //Game over UI is visible
        gameOverCanvas.SetActive(true);
        //Spawner set to invisible in the game
        spawner.SetActive(false);
        //The speed for the game is now at a stopping state
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

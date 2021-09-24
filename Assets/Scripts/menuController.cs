using UnityEngine;

public class menuController : MonoBehaviour
{



    public void home()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");


    }
    public void GamePlay()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        scoreFucs.playerScore = 0;


    }
    public void GameOver()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");


    }


    public void reloadGamePlay()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        scoreFucs.playerScore = 0;


    }

    public void Exit()
    {

        Application.Quit();


    }

    public void HighScoreScene()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("High score");


    }

}

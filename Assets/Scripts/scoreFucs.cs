using UnityEngine;
using UnityEngine.UI;
public class scoreFucs : MonoBehaviour
{

    [SerializeField]
    private Text scoreText;



    [SerializeField]
    private Text scoreTextStatic;
    public static int playerScore = 0;

    private int x = 0;
    public static int highScore = 0;

    public static int scoreUper = 0;

    private void Start() {

        highScore = PlayerPrefs.GetInt("HighScore",0);
        // scoreUper = 1;
        
    }

    void FixedUpdate()
    {
        updateScore();
    }

    void updateScore(){

        if(x > 10){
            playerScore += scoreUper;
            x = 0;

        }
        x += 1;

        scoreText.text = "Score: " + playerScore.ToString("0");

        updateHighScore();

    }

    public static void updateScoreStatic(){
        playerScore += 1;
        // scoreTextStatic.text = "Score: " + playerScore.ToString("0");
    }

    public static void resetScore(){

        playerScore = 0;

    }

    void updateHighScore(){

        if(playerScore > highScore){

            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore",highScore);
        }

    }
        
    

    void setSore(){

        scoreText.text = "Score: " + playerScore.ToString("0");
        scoreUper = 0;

    }
}

using UnityEngine;

public class downPins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){

            UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");
            scoreFucs.playerScore = 0;
        }
        else if(other.CompareTag("upBoxCollaider")){

            UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");
            scoreFucs.playerScore = 0;
        }

    }

}

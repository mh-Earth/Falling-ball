using UnityEngine;



public class gameOverDown : MonoBehaviour


{
    private bool isFirst = true;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (isFirst)
        {
            isFirst = false;
            return;
        }

        else if (other.CompareTag("Player"))
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");

        }


    }
}

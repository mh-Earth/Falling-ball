using UnityEngine;
// using UnityEngine.SceneManagement;
public class gameoverPin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Debug.Log("Game over");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");
        }

    }
}



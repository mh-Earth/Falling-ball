using UnityEngine;
using UnityEngine.UI;
public class setScores : MonoBehaviour
{


    [SerializeField]
    private Text scoretextObj;

    private void Update()
    {
        setscores();
    }

    void setscores()
    {

        scoretextObj.text = "Score: " + scoreFucs.playerScore.ToString("0");

    }

}

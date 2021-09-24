using UnityEngine;
using UnityEngine.UI;
public class gamePlayscene : MonoBehaviour
{
    [SerializeField]
    private Text startText;

    private int countter = 4;

    private int x = 40;

    private void Start() {
        scoreFucs.scoreUper = 0;
    }

    private bool ifsecend = true;
    private void LateUpdate()
    {

        if (countter > 0)
        {

            if (x < 0)
            {
                x = 40;
                countter -= 1;
            }

            x -= 1;

            startText.text = "Start in " + countter +"..........";
            return;
        }

        else if (ifsecend){
            startText.text = " ";
            scoreFucs.scoreUper = 1;
            playerMovement.playerSpeed = 12f;
            opticalsMovment.opticalSpeed = 4f;
            ifsecend = false;
        }

        else{

        }

    }
}

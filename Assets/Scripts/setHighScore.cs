using UnityEngine;
using UnityEngine.UI;
public class setHighScore : MonoBehaviour
{

    [SerializeField]
    private Text highObj;


    private void LateUpdate()
    {
        // highObj.tex
        highObj.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

}

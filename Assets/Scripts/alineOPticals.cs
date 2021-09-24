using UnityEngine;

public class alineOPticals : MonoBehaviour
{

        // Start is called before the first frame update
    public static float nextOpticalsPos;

    [SerializeField]
    private GameObject[] opticalList;

    private float opticalGaps = 3.15f;
    private float opticalStartposition = 10.82f-(3.15f)*10f;
    // Start is called before the first frame update

    private int randomx2;

    private void Start() {
    
        
        Debug.Log(nextOpticalsPos);
        for (int i = 0; i < opticalList.Length; i++)
        {   
            randomx2 = Random.Range(-8, 7);
            opticalList[i].transform.position = new Vector3(randomx2, opticalStartposition, 0f);
            opticalStartposition -= opticalGaps;
            // Debug.Log(opticalStartposition);


        }
        nextOpticalsPos = opticalStartposition +(3.15f)*10;
        Debug.Log(nextOpticalsPos);
        Destroy(opticalList[0]);
}  

}

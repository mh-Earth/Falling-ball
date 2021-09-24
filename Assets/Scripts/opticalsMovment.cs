using UnityEngine;
using UnityEngine.UI;
public class opticalsMovment : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public static float opticalSpeed = 4f;
    // Update is called once per frame
    private int ranndomX;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    public static bool moverOpticals = true;
    private SpriteRenderer sr;

    [SerializeField]
    private Sprite biri2;
    [SerializeField]
    private Sprite biri;

    


private void Start() {
    
        
        // Debug.Log(nextOpticalsPos);
        sr = GetComponent<SpriteRenderer>();
}  


    void Update()
    {
        opticalMove();
        shikeSize();
    }


    void opticalMove()
    {   
        if (moverOpticals)
        {
        transform.position += new Vector3(0f, opticalSpeed, 0f) * Time.deltaTime;
            
        } 

    }

    // Distance btw an opticals in vertical is 3.12
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ranndomX = Random.Range(-8, 7);
        // ranndomX = Random.Range(-3,1); for mobile
        // Debug.Log(ranndomX);
        transform.position = new Vector3(ranndomX, alineOPticals.nextOpticalsPos, 0f);
        if (collision.CompareTag("upBoxcollaider"))

        {

            transform.position += new Vector3(0f, 0f, 0f);

        }

    }


    void shikeSize()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            transform.localScale -= new Vector3(.003f, 0f, 0f) * Time.deltaTime;
            sr.sprite = biri2;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale += new Vector3(0f, 0f, 0f) * Time.deltaTime;
            sr.sprite = biri;


        }



    }
}

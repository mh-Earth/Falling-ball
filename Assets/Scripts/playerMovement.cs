using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField]
    public static float playerSpeed = 0f;

    [SerializeField]
    private float playerX;

    [SerializeField]
    private float gravityForce = 6f;
    private Rigidbody2D mybody;
    [SerializeField]
    private GameObject player;

    private SpriteRenderer Sr;
    private Animator playeranimation;

    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
        Sr = GetComponent<SpriteRenderer>();
        // mybody.gravityScale = 2;
        mybody.velocity = new Vector2(0f, -gravityForce);

        playeranimation = GetComponent<Animator>();
        playeranimation.SetBool("moveRight", false);
        playeranimation.SetBool("moveLeft", false);
    }

    // Update is called once per frame

    void Update()
    {

        playerMovementX();
        speedup();



    }

    void playerMovementX()
    {

        playerX = Input.GetAxisRaw("Horizontal");
        if (playerX < 0)
        {

            // transform.position += new Vector3(-1,0f,0f)*Time.deltaTime*playerSpeed;
            mybody.velocity = new Vector2(-playerSpeed, -gravityForce);
        }

        else if (playerX > 0)
        {

            // transform.position += new Vector3(1,0f,0f)*Time.deltaTime*playerSpeed;
            mybody.velocity = new Vector2(playerSpeed, -gravityForce);
            // transform.Rotate = new Vector3(0f,0f,-36f);
            // transform.Rotate = new Vector3(0f,0f,0f);
        }
        else
        {
            // transform.position += new Vector3(0f,0f,0f)*Time.deltaTime*playerSpeed;
            mybody.velocity = new Vector2(0f, -gravityForce);
            // transform.Rotate = new Vector3(0f,0f,0f);
            // playerTransform.Rotate = new Vector3(0f,0f,0f);;

        }
    }



    void speedup()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            playerSpeed = 18f;
            opticalsMovment.opticalSpeed = 2f;
            playeranimation.SetBool("pinic", true);
            mybody.velocity = new Vector2(0f, -gravityForce / 2);
            Sr.color = Color.red;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerSpeed = 12f;
            opticalsMovment.opticalSpeed = 4f;
            playeranimation.SetBool("pinic", false);
            playeranimation.SetBool("idel", true);
            mybody.velocity = new Vector2(0f, -gravityForce);
            // Debug.Log(playerSpeed);
            // playerSpeed = 4f;
            Sr.color = new Color(255f, 126f, 0f);
        }
    }
}

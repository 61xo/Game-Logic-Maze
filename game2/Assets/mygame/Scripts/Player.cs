using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    public static bool player1 = true;
    public float runSpeed = 3f; 
    public float jumpForce = 8f; 

    private Rigidbody2D body;
  

     bool isrun=false;
     bool isjump=false;
    private bool isGrounded;
    public GameObject groundCheckPoint;
    public float groundCheckRadius;


    public Animator ainm;
  public LayerMask groundLayer; 
   
    public static bool Idv=false;
    void Awake()
    {
       
        body = GetComponent<Rigidbody2D>();
       
    }

    // Update() is called every frame.
    void Update()
    {
        ainm.SetBool("run", isrun);
        ainm.SetBool("jump",isjump);
        if(isGrounded ) { isjump = false; }
        else { isjump = true; }

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.transform.position, groundCheckRadius, groundLayer);
        if (!Player.player1) { isjump = false; isrun = false; }
        if (Input.GetKeyDown(KeyCode.Escape)) { 
           
            SceneManager.LoadSceneAsync(0);
        }
        
        if (Player.player1)
        {
        /////////

      
            ///////
          
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    SoundB.jump.Play();
                    body.velocity = new Vector2(0, jumpForce);
                }

            }

            if (Input.GetKey(KeyCode.A))
            {

                body.velocity = new Vector2(-runSpeed, body.velocity.y);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);

                isrun = true;

            }

            else if (Input.GetKey(KeyCode.D))
            {

                body.velocity = new Vector2(runSpeed, body.velocity.y);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
                isrun = true;
            }
            else {
                body.velocity = new Vector2(0, body.velocity.y);
                isrun = false;
            }
        }
      
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Player.player1) Player.player1 = false;
          else if (!Player.player1) Player.player1 = true;
        }




        if (Input.GetKeyDown(KeyCode.O))
        {
            Idv = true;


        }
    }
   

}

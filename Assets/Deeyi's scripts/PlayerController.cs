using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float movementValueX = 2.0f;
    float jumpHeight = 3f;
    public Text scoreText;

    public Transform cam;
    bool atEdge;
    bool moving;
    string dir;

    public GameObject groundChecker;
    public GameObject talkStuff;
    bool talkDistance = false;
    bool talkDistance1 = false;
    bool talkDistance2 = false;
    public LayerMask whatIsGround;
    public bool doubleJump = true;
    public GameObject convoStart;
    public GameObject convoStart1;
    public GameObject convoStart2;
    public float moveSpeed = 2.5f;
    float scoreTimer = 0f;
    public LayerMask player;
    public float sprintSpeed = 2.5f;

    public GameObject mySprite;

    float myXScale;

    public List<string> items;

    int score = 0;
   // Animator myAnim;
    bool isOnGround = false;

  //  Animator anim;
    Rigidbody2D playerObject;
    // Start is called before the first frame update
    void Start()
    {
     //   anim = mySprite.GetComponent<Animator>();
        playerObject = GetComponent<Rigidbody2D>();
        atEdge = false;
        moving = false;
        dir = "right";
        myXScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempX = Vector2.Lerp(cam.transform.position, transform.position, Time.deltaTime);

        Vector2 tempY = Vector2.Lerp(cam.transform.position, transform.position, Time.deltaTime);
        //playerObject.velocity
        cam.transform.position = new Vector3(tempX.x, tempY.y, cam.transform.position.z);
        //cam.transform.position
       // cam.transform.position.y
        if (!atEdge)
        {
            if (moving)
            {
                Move();
            }
        }

        Collider2D coll = Physics2D.OverlapCircle(transform.position, 5f, player);

     //   Debug.Log(coll);

        if (coll != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                coll.gameObject.GetComponent<Mum>().TriggerDialogue();
            }
        }

       /*
        scoreTimer += Time.deltaTime;

        if (scoreTimer >= 0.5f)
        {
            score++;
            scoreTimer = 0f;
        }
        /*
        if (Input.GetKey(KeyCode.LeftShift))
        {

            moveSpeed = 5f;
        }
        else
        {
            moveSpeed = 2.5f;

        }

        */



        float movementValueX = Input.GetAxis("Horizontal");
        //float movementValueY = Input.GetAxis("Vertical");

        if (movementValueX < 0)
        {
            Vector2 newScale = new Vector2(-myXScale, transform.localScale.y);
            transform.localScale = newScale;
        }
        else if (movementValueX > 0)
        {
            Vector2 newScale = new Vector2(myXScale, transform.localScale.y);
            transform.localScale = newScale;
        }


        playerObject.velocity = new Vector2(movementValueX * moveSpeed, playerObject.velocity.y);

       // Debug.Log(playerObject.velocity);
        
      //  anim.SetFloat("speed", Mathf.Abs(movementValueX));


         isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);
         if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
         {
             playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
             playerObject.AddForce(new Vector2(0.0f, 100.0f * jumpHeight));

         }
         else if (Input.GetKeyDown(KeyCode.Space) && doubleJump)
         {
             playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
             Debug.Log('d');
             playerObject.AddForce(new Vector2(0.0f, 100.0f * jumpHeight));
             doubleJump = false;
         }

         if (isOnGround == true)
         {
             doubleJump = true;




         }


        /*if (transform.position.y <= -6)
        {
            Time.timeScale = 0.0f;
        }*/


        scoreText.text = score.ToString();



    }
    void Move()
    {
        if (dir == "left")
        {
            //cam.Translate(new Vector2(-0.00905f, 0f));
        }
        else
        {
            //cam.Translate(new Vector2(0.00905f, 0f));
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PickUp")
        {
            score ++;
            Destroy(collision.gameObject);
        }



    }

    /*public void CollectItem(string itemIn)
    {
        int indX = items.IndexOf(itemIn);
        items.RemoveAt(indX);
    }

    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        
       
        
        
        if (other.tag == "left")
        {
            moving = true;
            dir = "left";
        }
        else if (other.tag == "right")
        {
            moving = true;
            dir = "right";
        }
        else if (other.tag == "boundary")
        {
            atEdge = true;
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "left")
        {
            moving = false;
            dir = "left";
        }
        else if (other.tag == "right")
        {
            moving = false;
            dir = "right";
        }
        else if (other.tag == "boundary")
        {
            atEdge = false;
        }


    }

    public void CollectItem(string itemIn)
    {
        int indX = items.IndexOf(itemIn);
        items.RemoveAt(indX);
    }
    */
}
  
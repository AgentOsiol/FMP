using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brother : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Rigidbody2D playerObject1; 
   // playerObject1 = GetComponent<Rigidbody2D>();
    public GameObject player;
    public GameObject destination;
    public float speedAi;
    float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = destination.transform.position - transform.position;

        if (distance < 4)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, destination.transform.position, speedAi * Time.deltaTime);

        }

    }
   /* private void OnCollision (Collision other)
    {
        if (other.tag == "Jumppoint")
        {
            
            playerObject1.velocity = new Vector2(playerObject1.velocity.x, 0f);
            playerObject1.AddForce(new Vector2(0.0f, 100.0f));
        }



    }
    */

}

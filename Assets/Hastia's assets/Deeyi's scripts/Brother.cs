using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brother : MonoBehaviour
{
    // Start is called before the first frame update
    
    Rigidbody2D playerObject1; 
   
    public GameObject player;
    public GameObject destination;
    public float speedAi;
    float distance;
    void Start()
    {
         playerObject1 = GetComponent<Rigidbody2D>();
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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Jumppoint"))
        {
            Debug.Log("you did it");
            playerObject1.velocity = new Vector2(playerObject1.velocity.x, 0f);
            playerObject1.AddForce(new Vector2(0.0f, 100.0f));
        }



    }
    

}

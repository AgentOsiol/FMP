using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody2D Character;
    // Start is called before the first frame update
    void Start()
    {
        Character = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement left and right
       Move = Input.GetAxisRaw("Horizontal");

       Character.velocity = new Vector2(Move * speed, Character.velocity.y);

        // Jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            Character.AddForce(new Vector2(0.0f, 100.0f));
        }

        
        
    }
}

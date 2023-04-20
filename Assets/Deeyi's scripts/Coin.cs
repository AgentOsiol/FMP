using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    public float ballSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.AddForce(new Vector2(-ballSpeed, 0.0f));

    }
}
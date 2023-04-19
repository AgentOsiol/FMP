using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeBall : MonoBehaviour
{
    
    Rigidbody2D rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.AddForce (new Vector2(0.0f, 100.0f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brother : MonoBehaviour
{
    // Start is called before the first frame update

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
}

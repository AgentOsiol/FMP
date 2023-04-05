using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMiniGame : MonoBehaviour
{
    Rigidbody2D ballfizz;
    //public GameObject leftdestination;
    public GameObject footBall;
    public GameObject topRight;
    bool rightSwitch = false;
    bool leftSwitch = false;
    float numberpicker = 0;
    public GameObject topLeft;
    float shootSpeed = 100;
    // Start is called before the first frame update
    
    void Start()
    {
        ballfizz = GetComponent<Rigidbody2D>();
        numberpicker = Random.Range(1, 2);
        Debug.Log(numberpicker);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (numberpicker == 1)
        {



        }



        Vector2 directionLeft = topLeft.transform.position - transform.position;
        Vector2 directionRight = topRight.transform.position - transform.position;
        if (leftSwitch == true)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topLeft.transform.position, shootSpeed * Time.deltaTime);
        }
        if (rightSwitch == true)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, shootSpeed * Time.deltaTime);



        }

    }
    public void shootLeft()
    {
        Debug.Log("L");
        //ballfizz.AddForce(new Vector2(0.0f, 0.1f));
        leftSwitch = true;
          //transform.position = Vector2.MoveTowards(this.transform.position, topLeft.transform.position, shootSpeed * Time.deltaTime);
    }

    public void shootRight()
    {
        Debug.Log("R");
       // transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, shootSpeed * Time.deltaTime);
        rightSwitch = true;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMiniGame : MonoBehaviour
{
   
    //public GameObject leftdestination;
    public GameObject footBall;
    public GameObject keeper;
    public GameObject topRight;
    bool rightSwitch = false;
    bool leftSwitch = false;
    float numberpicker = 0;
    public GameObject topLeft;
    float shootSpeed = 100;
    // Start is called before the first frame update
    
    void Start()
    {
        
        numberpicker = Random.Range(1, 3);
        Debug.Log(numberpicker);
        
    }

    // Update is called once per frame
    void Update()
    {

       



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
        
        leftSwitch = true;
        
        if (numberpicker == 1 & leftSwitch == true)
        {

            Debug.Log("you missed");
        }
        else if (numberpicker == 2 & rightSwitch == true)
        {

            Debug.Log("you missed");
        }
        else
        {
            Debug.Log("you scored");

        }

        if (numberpicker==1)
        {

            transform.position = Vector2.MoveTowards(keeper.transform.position, topLeft.transform.position, shootSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(keeper.transform.position, topRight.transform.position, shootSpeed * Time.deltaTime);
        }
    }

    public void shootRight()
    {
        Debug.Log("R");
       // transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, shootSpeed * Time.deltaTime);
        rightSwitch = true;
        if (numberpicker == 1 & leftSwitch == true)
        {

            Debug.Log("you missed");
        }
        else if (numberpicker == 2 & rightSwitch == true)
        {

            Debug.Log("you missed");
        }
        else
        {
            Debug.Log("you scored");

        }

        if (numberpicker == 1)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topLeft.transform.position, shootSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, shootSpeed * Time.deltaTime);
        }

    }


}

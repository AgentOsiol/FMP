using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperMiniGame : MonoBehaviour
{
    public GameObject topRight;
    public GameObject topLeft;
    GoalMiniGame goalMiniGame;
    public GameObject lefty;
    public GameObject righty;
    public GameObject middle;

    float keeperSpeed = 100; 
    // Start is called before the first frame update
    void Start()
    {
        goalMiniGame = GameObject.Find("Football").GetComponent<GoalMiniGame>();
        lefty.SetActive(false);
        righty.SetActive(false);
        middle.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(goalMiniGame.numberpicker);
        if  (goalMiniGame.leftSwitch == true& goalMiniGame.numberpicker ==1)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topLeft.transform.position, keeperSpeed* Time.deltaTime);
            lefty.SetActive(true);
            middle.SetActive(false);
        }
        
        if (goalMiniGame.leftSwitch == true & goalMiniGame.numberpicker == 2)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, keeperSpeed * Time.deltaTime);
            middle.SetActive(false);
            righty.SetActive(true);
        }

        if (goalMiniGame.rightSwitch == true & goalMiniGame.numberpicker == 1)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topLeft.transform.position, keeperSpeed* Time.deltaTime);
            middle.SetActive(false);
            lefty.SetActive(true);
        }
        if (goalMiniGame.rightSwitch == true & goalMiniGame.numberpicker == 2)
        {

            transform.position = Vector2.MoveTowards(this.transform.position, topRight.transform.position, keeperSpeed * Time.deltaTime);
            middle.SetActive(false);
            righty.SetActive(true);
        }
    }
    

}

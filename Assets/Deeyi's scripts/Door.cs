using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int  sceneNum = 6;
    bool doorTouch=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorTouch == true)
        {
            SceneManager.LoadScene(sceneNum);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            doorTouch = true;
          //  Debug.Log ("you did it");
        }
    }
}

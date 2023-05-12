using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DodgeBall : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject continueButton;
    public int sceneNo = 0;
    Rigidbody2D rigidbody2D;
    public float ballSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        restartButton.SetActive(false);
        continueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.AddForce (new Vector2(-ballSpeed, 0.0f));

    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            // Destroy(collision.gameObject);
            Time.timeScale = 0;
            restartButton.SetActive (true);
            continueButton.SetActive(true);
        }
    }
    public void RestartTheGame(){

        
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ContinueGame()
    {
        SceneManager.LoadScene(sceneNo);
        Time.timeScale = 1;
    }



}

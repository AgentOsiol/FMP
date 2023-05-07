using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fireFlies;
    public int sceneNo = 0;
    public GameObject nextScene;
    
    void Start()
    {
        nextScene.SetActive(false);
        
    }

    void Update()
    {
        if (fireFlies.activeSelf)
        {
            nextScene.SetActive(false);
            

        }
        else
        {
            nextScene.SetActive(true);

        }
    }
    public void nextscene()
    {

        SceneManager.LoadScene(sceneNo);

    }

    // Update is called once per frame
   
}

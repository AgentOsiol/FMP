using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeBowlAppearScript : MonoBehaviour
{
   
    public GameObject Bowl;

    // Start is called before the first frame update
    void Start()
    {
        Bowl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerManager manager = Bowl.GetComponent<PlayerManager>();
        if (manager.ingredientCount > 5)
        {
            Bowl.SetActive(true);
        }

    }
}

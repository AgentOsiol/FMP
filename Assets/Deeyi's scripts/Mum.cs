using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Mum: MonoBehaviour
{
    public GameObject fireFlies;
    // Start is called before the first frame update
    public Dialogue Npc;
    // Canvas.GetComponent<Dialogue>().Dialogue; 
    bool dialogTriggered = false;

    private void Start()
    {
        fireFlies.SetActive(true);
    }


    
    public void TriggerDialogue()
    {
        fireFlies.SetActive(false);
        if (dialogTriggered == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(Npc);
            dialogTriggered = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Queue<string> sentences;
    public GameObject textBox;
   // public Animator textBox1;
    public Text nameText;
    public Text dialogueText;
    public GameObject fireFlies;
    public GameObject wake;
  //  Animator anim;

    void Start()
    {
        sentences = new Queue<string>();
       // wake.SetActive(true);
        //textBox1 = GetComponentInChildren<Animator>();
        textBox.SetActive(false);
       // anim = GetComponent<Animator>();
        fireFlies.SetActive(true);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            DisplayNextSentence();
        }
       // Debug.Log();
    }



    public void StartDialogue(Dialogue dialogue)
    {
       // textBox1.SetTrigger("Isopen");
       fireFlies.SetActive(false);
       // textBox1.SetTrigger("Isopen");
        Debug.Log("starting a convertion with" + dialogue.name);
      // anim.SetBool("Isopen", true);
        textBox.SetActive(true);
       // textBox.SetActive(false);
        nameText.text = dialogue.name;
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence ()
    {
        
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
           


        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        IEnumerator TypeSentence (string sentence)
        {
            dialogueText.text  ="";
            foreach(char letter in sentence.ToCharArray())
            {
                dialogueText.text+= letter;
                yield return new WaitForSeconds(0.05f);

            }
        
        
        
        }
        void EndDialogue()
        {

            textBox.SetActive(false);
            Debug.Log("End of conversati");
            // textBox1.SetBool("Isopen", false);
            // textBox1.set("Isopen");
          //  anim.SetBool("Isopen", false);
            // wake.SetActive(false);
           // fireFlies.SetActive(false);
        }

    }
    
    // Update is called once per frame
    
}

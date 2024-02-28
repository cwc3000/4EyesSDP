using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    public bool playedOnce = false;
    public float delay = 5.0f;
    float timer = 0;
    bool timerReached = false;

    public GameObject waitUntilOpen;

    // for on mouse click event for that which needs a delay
    public void Update()
    {
        if (!timerReached && waitUntilOpen.activeInHierarchy == true)
            timer += Time.deltaTime;

        if (!timerReached && timer > delay)
        {
            timerReached = true;
            triggerDialogue();
            
        }
    }
    public void triggerDialogue()
    {
        //Invoke("StartDialogue", 3);
        //if (waitUntilOpen.activeInHierarchy == true)
        //{
        //    timer += Time.deltaTime;
        //}
        
        
        
        //if (waitUntilOpen.activeInHierarchy == true && timer > delay)
        //{
        //    FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
        //    playedOnce = true;
        //}
        //else
        //{
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
        playedOnce = true;
        //}
        if (playedOnce && gameObject.tag == "email")
        {
            Destroy(this);
        }
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    
    public float delay = 5.0f;
    //float timer = 0;
    //bool timerReached = false;
    
    public bool playOnceOnly = false;
    public GameObject activateDialogue;
    public GameObject[] prohibitProgression;

    public bool isDelay = false;
    public GameObject waitUntilOpen;

    public bool finalDialogue = false;

    // for on mouse click event for that which needs a delay
    public void Update()
    {
        //if (!timerReached && waitUntilOpen.activeInHierarchy == true)
        //    timer += Time.deltaTime;

        //if (!timerReached && timer > delay && isDelay)
        //{
        //    timerReached = true;
        //    triggerDialogue(); 
        //}

        if (waitUntilOpen.activeInHierarchy == true)
        {
            Destroy(prohibitProgression[0]);
            Destroy(prohibitProgression[1]);
            Destroy(prohibitProgression[2]);
            Destroy(prohibitProgression[3]);
            Destroy(prohibitProgression[4]);
        }
    }
    public void triggerDialogue()
    {
        dialogueManager DialogueManager = FindObjectOfType<dialogueManager>();
        if (playOnceOnly)
        {
            Destroy(activateDialogue);
        }
        if (finalDialogue)
        {
            DialogueManager.isFinalDialogue = true;
        }

        DialogueManager.StartDialogue(dialogue);
        

        //else 

    }

    public void delayDialogue()
    {
        StartCoroutine(waitSeconds());
    }
    IEnumerator waitSeconds()
    {
        yield return new WaitForSeconds(delay);
        triggerDialogue();
    }

}

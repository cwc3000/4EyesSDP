using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    
    public float delay = 5.0f;
    float timer = 0;
    bool timerReached = false;
    
    public bool playOnceOnly = false;
    public GameObject activateDialogue;

    public bool isDelay = false;
    public GameObject waitUntilOpen;

    // for on mouse click event for that which needs a delay
    public void Update()
    {
        if (!timerReached && waitUntilOpen.activeInHierarchy == true)
            timer += Time.deltaTime;

        if (!timerReached && timer > delay && isDelay)
        {
            timerReached = true;
            triggerDialogue(); 
        }
    }
    public void triggerDialogue()
    {

        FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
        if (playOnceOnly)
        {
            Destroy(activateDialogue);
        }

    }
    
}

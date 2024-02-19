using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    public bool playedOnce = false;
    

    public void triggerDialogue()
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
        playedOnce = true;

        if (playedOnce && gameObject.tag == "email")
        {
            Destroy(this);
        }
        
    }
    
}

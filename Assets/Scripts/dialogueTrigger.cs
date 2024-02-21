using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    public bool playedOnce = false;
    public float delay = 5.0f;
    float timer;

    public void Update()
    {
        timer += Time.deltaTime;

        if (timer > delay && gameObject.tag == "email")
        {
            triggerDialogue();
        }
    }
    public void triggerDialogue()
    {
        //Invoke("StartDialogue", 3);

            FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
            playedOnce = true;

        if (playedOnce && gameObject.tag == "email")
        {
            Destroy(this);
        }
        
    }
    
}

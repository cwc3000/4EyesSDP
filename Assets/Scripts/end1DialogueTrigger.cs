using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end1DialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    public float delay = 5.0f;
    public GameObject restartButton;

    void Start()
    {
        delayDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        dialogueManager DialogueManager = FindObjectOfType<dialogueManager>();
        if (DialogueManager.dialogueFin)
        {
            StartCoroutine(waitRestart());
        }
    }

    public void triggerDialogue()
    {
        dialogueManager DialogueManager = FindObjectOfType<dialogueManager>();
        DialogueManager.StartDialogue(dialogue);
        
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

    IEnumerator waitRestart()
    {
        yield return new WaitForSeconds(1);
        restartButton.SetActive(true);
    }

}

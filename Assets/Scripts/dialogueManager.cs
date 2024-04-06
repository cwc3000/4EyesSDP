using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class dialogueManager : MonoBehaviour
{
    //public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Image charaExpression;
    public Animator animator;
    public float textSpeed = 0.02f;
    public GameObject waitUntilOpen;

    //public GameObject canvas;

    private Queue<string> sentences = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {

    }
    
    

    void Update()
    {
        
        if (Input.GetKeyDown("e"))
        {
            DisplayNextSentence();
        }
    }
    
    IEnumerator waitFor()
    {
        yield return new WaitForSeconds(3);
    }

    public void StartDialogue(dialogue dialogue)
    {
        //Debug.Log("Starting convo with " + dialogue.name);

        //StartCoroutine(waitSeconds());
        //canvas.GetComponentsInChildren(true)
        Cursor.lockState = CursorLockMode.Locked;

        animator.SetBool("isOpen", true);

        //nameText.text = dialogue.name;
        charaExpression.sprite = dialogue.characterExpression;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //IEnumerator waitSeconds()
    //{
    //    yield return new WaitForSeconds(3);
    //}

    void EndDialogue()
    {
        //Debug.Log("End of convo");

        animator.SetBool("isOpen", false);
        Cursor.lockState = CursorLockMode.None;
    }
}

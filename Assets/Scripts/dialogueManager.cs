using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class dialogueManager : MonoBehaviour
{
    //public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Image charaExpression;
    public Sprite[] expressionSprites;
    public int expressionNum = 0;

    public Animator animator;
    public float textSpeed = 0.02f;
    //public GameObject finalAttachment;
    public bool isFinalDialogue = false;
    public bool dialogueFin = false;
    public bool lockCursor = true;

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
    
    //IEnumerator waitFor()
    //{
    //    yield return new WaitForSeconds(3);
    //}

    //public void delayDialogue()
    //{

    //}

    public void StartDialogue(dialogue dialogue)
    {
        //Debug.Log("Starting convo with " + dialogue.name);

        //StartCoroutine(waitSeconds());
        //canvas.GetComponentsInChildren(true)
        dialogueFin = false;
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        animator.SetBool("isOpen", true);

        //nameText.text = dialogue.name;
        charaExpression.sprite = expressionSprites[expressionNum]; // = dialogue.characterExpression;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //isFinalDialogue &&

        //if (isFinalDialogue)
        //{
        //    StartCoroutine(waitSeconds());
        //}
        //else if (!isFinalDialogue)
        //{
            DisplayNextSentence();
        //}
        
    }
    //IEnumerator waitSeconds()
    //{
    //    yield return new WaitForSeconds(5);
    //    StartDialogue();
    //}

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
        dialogueFin = true;
    }

    

    void EndDialogue()
    {
        //Debug.Log("End of convo");
        
        animator.SetBool("isOpen", false);
        Cursor.lockState = CursorLockMode.None;

        if (isFinalDialogue)
        {
            SceneManager.LoadScene("End2");
        }
    }
}

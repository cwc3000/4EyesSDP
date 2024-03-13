using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class messageManager : MonoBehaviour
{

    public TMP_Text messageText;
    public GameObject otherMessage;
    public float textSpeed = 0.02f;

    //public Animator rileyAnimator;
    public GameObject contentArea;

    //bool finishedMessage;

    private Queue<string> messages;


    void Start()
    {
        messages = new Queue<string>();
    }


    void Update()
    {
        StartCoroutine(waitSeconds());
        
    }

    IEnumerator waitSeconds()
    {
        yield return new WaitForSeconds(3);
        DisplayNextMessage();
    }

    public void StartMessage(Message Message)
    {

        otherMessage.GetComponent<Animator>().SetBool("isOpen", true);
        otherMessage.GetComponent<Animator>().SetBool("isStay", true);
        //GameObject newMessageBox = Instantiate(otherMessage, contentArea.transform);
        messages.Clear();

        foreach (string message in Message.messages)
        {
            messages.Enqueue(message);
        }

        DisplayNextMessage();
    }

    public void DisplayNextMessage()
    {
        
        if (messages.Count == 0)
        {
            EndDialogue();
            return;
        }

        string message = messages.Dequeue();

        messageText.text = "";
        
        //foreach (string message in Message.messages)
        //{
        //    GameObject newMessageBox = Instantiate(otherMessage, contentArea.transform);
        //    newMessageBox.SetActive(true);
            
        //}
        
        
        StopAllCoroutines();
        StartCoroutine(TypeMessage(message));
        }

    IEnumerator TypeMessage(string message)
    {
        messageText.text = "";
        foreach (char letter in message.ToCharArray())
        {
            messageText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void EndDialogue()
    {
        otherMessage.GetComponent<Animator>().SetBool("isStay", true);
    }
}


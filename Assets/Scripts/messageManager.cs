using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class messageManager : MonoBehaviour
{

    //public TMP_Text messageText;
    public GameObject otherMessage;
    public float textSpeed = 0.02f;

    //public Animator rileyAnimator;
    public GameObject contentArea;

    bool finishedMessage;

    private Queue<string> messages;
    GameObject newMessageBox = null;

    void Start()
    {
        messages = new Queue<string>();
    }


    void Update()
    {
        StartCoroutine(waitSeconds());

        //if (finishedMessage == true)
        //{
        //    DisplayNextMessage();
        //}

    }

    // wait a few seconds before displaying the next message
    IEnumerator waitSeconds()
    {
        yield return new WaitForSeconds(3);
        DisplayNextMessage();
    }

    public void StartMessage(Message Message)
    {
        messages.Clear();

        foreach (string message in Message.messages)
        {
            messages.Enqueue(message);
        }

        DisplayNextMessage();
    }

    public void DisplayNextMessage()
    {
        // this may be unneeded since nothing happens in the EndMessage function but leaving it in case I need to add choices
        if (messages.Count == 0)
        {
            EndMessages();
            return;
        }

        // return next message
        string message = messages.Dequeue();

        // create a new text message box to correct area, and then set it to open so it plays the message pop up animation
        newMessageBox = Instantiate(otherMessage, contentArea.transform);
        newMessageBox.SetActive(true);
        //newMessageBox.GetComponent<Animator>().SetBool("isStay", true); 
        newMessageBox.GetComponent<Animator>().SetBool("isOpen", true);
        
        // set the new message box's text component to include the actual message it should print
        newMessageBox.GetComponentInChildren<TMP_Text>().text = message;
        
        
        StopAllCoroutines();
        //StartCoroutine(TypeMessage(message));
        }

    // not using typing for messages since I want them to instantly pop up like for messaging rather than dialogue
    IEnumerator TypeMessage(string message)
    {
        newMessageBox.GetComponentInChildren<TMP_Text>().text = "";
        foreach (char letter in message.ToCharArray())
        {
            newMessageBox.GetComponentInChildren<TMP_Text>().text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
        //if (letter == 0)
        //{
        //    finishedMessage = true;
        //}
    }

    void EndMessages()
    {
        //newMessageBox.GetComponent<Animator>().SetBool("isOpen", true);
        //newMessageBox.GetComponent<Animator>().SetBool("isStay", true);
    }
}


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
    public GameObject rileyMessage;

    

    public float textSpeed = 0.02f;

    public GameObject contentArea;

    public bool finishedMessage;
    private bool isRiley;
    //public bool isOther;
    private List<Message> messages = new List<Message>();
    GameObject newMessageBox = null;

    //[SerializeField] Button[] senderTriggers;



    void Awake()
    {
        finishedMessage = false;
    }
    void Start()
    {
        //messages = new List<Message>();
        
        //foreach (Button sender in senderTriggers)
        //{
        //    Button sndr = sender;
        //    sender.onClick.AddListener(() => TaskOnClick(sender));

        //}

    }

    //void TaskOnClick(Button sndr)
    //{
    //    if (sndr.tag == "rileyMSG")
    //    {
    //        isRiley = true;
    //        isOther = false;
    //        //Debug.Log(isRiley);
    //    }
    //    if (sndr.tag == "otherMSG")
    //    {
    //        isRiley = false;
    //        isOther = true;
    //        //Debug.Log(isOther);
    //    }
    //}


    void Update()
    {
        //StartCoroutine(waitSeconds());

        //if (finishedMessage == true)
        //{
        //    DisplayNextMessage();
        //}

    }

    // wait a few seconds before displaying the next message
    IEnumerator waitSeconds()
    {
        DisplayNextMessage();
        yield return new WaitForSeconds(3);  
    }

    public void StartMessage(MessageHolder Message)
    {
        messages.Clear();

        foreach (Message message in Message.messages)
        {
            messages.Add(message);
            //isRiley = message.isRiley;
        }

        //StartCoroutine(waitSeconds());
        InvokeRepeating("DisplayNextMessage",0, 3.0f);
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
        Message message = messages[0];
        messages.RemoveAt(0);

        if (message.isRiley)
        {
            //Debug.Log(isRiley);
            newMessageBox = Instantiate(rileyMessage, contentArea.transform);
            newMessageBox.SetActive(true);
            newMessageBox.GetComponentInChildren<Animator>().SetBool("isOpen", true);
            //newMessageBox.GetComponentInChildren<Animator>().keepAnimatorStateOnDisable;
            // set the new message box's text component to include the actual message it should print
            newMessageBox.GetComponentInChildren<TMP_Text>().text = message.message;
        }
        else 
        {
            Debug.Log("not Riley");
            // create a new text message box to correct area, and then set it to open so it plays the message pop up animation
            newMessageBox = Instantiate(otherMessage, contentArea.transform);
            newMessageBox.SetActive(true);
            //newMessageBox.GetComponent<Animator>().SetBool("isStay", true); 
            newMessageBox.GetComponentInChildren<Animator>().SetBool("isOpen", true);

            // set the new message box's text component to include the actual message it should print
            newMessageBox.GetComponentInChildren<TMP_Text>().text = message.message;
        }
        
        
        
        StopAllCoroutines();
        }

    void EndMessages()
    {
        CancelInvoke("DisplayNextMessage");
        finishedMessage = true;
        
        Debug.Log("finished message" + finishedMessage);
        //isRiley = false;
        //isOther = false;
        //newMessageBox.GetComponent<Animator>().SetBool("isOpen", true);
        //newMessageBox.GetComponent<Animator>().SetBool("isStay", true);
    }
}


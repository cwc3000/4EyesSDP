using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTrigger : MonoBehaviour
{
    public MessageHolder message;
    public GameObject choicesObj;
    //public Button sender;
    public bool isRiley;
    public messageManager mM;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (mM.finishedMessage == true)
        {
            choicesObj.SetActive(true);
        }
    }

    public void triggerMessage()
    {
        //sender.onClick.AddListener(() => TaskOnClick(sender));
        FindObjectOfType<messageManager>().StartMessage(message);

        //mM.StartMessage(message);
        
        
        //if (gameObject.tag == "rileyMSG")
        //{
        //    Destroy(choicesObj);
        //}
        
    }

    //void TaskOnClick(Button sender)
    //{
    //    if (sender.gameObject.tag == "rileyMSG")
    //    {
    //        isRiley = true;
    //    }
    //}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageTrigger : MonoBehaviour
{
    public Message message;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerMessage()
    {
        FindObjectOfType<messageManager>().StartMessage(message);
    }
}

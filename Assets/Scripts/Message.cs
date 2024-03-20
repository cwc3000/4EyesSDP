using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MessageHolder
{
    public Message[] messages;
}

[System.Serializable]
public class Message
{
    [TextArea(3, 10)]
    public string message;
    public bool isRiley;
}

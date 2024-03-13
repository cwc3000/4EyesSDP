using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Message
{
    //public string speaker;
    [TextArea(3, 10)]
    public string[] messages;
}


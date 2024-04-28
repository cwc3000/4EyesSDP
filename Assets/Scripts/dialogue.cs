using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
//public class dialogueHolder
//{
//    public string name;
//    public dialogue[] dialogues; 
//}

[System.Serializable]
public class dialogue
{
    //public string name;
    public Sprite characterExpression;
    //public int expNum;
    [TextArea(3,10)]
    public string[] sentences;
}

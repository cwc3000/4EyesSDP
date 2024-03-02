using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Email", menuName = "Create New Email")]
public class emailItem : ScriptableObject
{
    public int id;
    public string emailTitle;
    public Sprite notif;
    public GameObject emailContent;
    public bool isDefaultEmail;


    public virtual void interact()
    {

    }

}

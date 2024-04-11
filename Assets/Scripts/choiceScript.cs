using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class choiceScript : MonoBehaviour
{
    public GameObject choiceScroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeChoiceScroll()
    {
        choiceScroll.SetActive(false);
    }
}

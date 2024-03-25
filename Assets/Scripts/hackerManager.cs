using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hackerManager : MonoBehaviour
{
    public GameObject spamBox;
    public GameObject contentArea;
    public Sprite[] spamImages;

    GameObject newSpamBox = null;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnSpamMsgs()
    {
        for (var i = 0; i < 6; i++){
            newSpamBox = Instantiate(spamBox, new Vector3(i*2,i*2 + 10,0), Quaternion.identity, contentArea.transform);
            newSpamBox.GetComponent<Image>().sprite = spamImages[Random.Range(0, 3)];
        }
        
    }
    public void lag()
    {
        Time.timeScale = 0.8f;
    }

    public void glitch()
    {

    }
}

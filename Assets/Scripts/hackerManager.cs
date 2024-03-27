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

    public void startSpamMSG()
    {
        InvokeRepeating("spawnSpamMsgs", 0, 0.5f);
    }
    
    public void spawnSpamMsgs()
    {
        for (var i = 0; i < 6; i++){
            newSpamBox = Instantiate(spamBox, new Vector3(-i*50 + 960, -i*60 + 540, 0), Quaternion.identity, contentArea.transform);
            StopAllCoroutines();
            newSpamBox.transform.Find("spam_Image").GetComponent<Image>().sprite = spamImages[Random.Range(0, 3)];
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

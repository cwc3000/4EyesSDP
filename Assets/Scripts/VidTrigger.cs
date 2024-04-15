using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerVideo1()
    {
        FindObjectOfType<VidPlayer>().PlayVideo();
    }

    public void pauseVideo1()
    {
        FindObjectOfType<VidPlayer>().PauseVideo();
    }

    public void triggerVideo2()
    {
        FindObjectOfType<VidPlayer2>().PlayVideo();
    }
    public void pauseVideo2()
    {
        FindObjectOfType<VidPlayer2>().PauseVideo();
    }

}

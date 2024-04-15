using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidPlayer2 : MonoBehaviour
{
    [SerializeField] string videoFileName;
    public GameObject activateVideo;

    // Start is called before the first frame update
    void Start()
    {
        //PlayVideo();
    }
    //void Update()
    //{
    //    if (activateVideo.activeInHierarchy)
    //    {
    //        PlayVideo();
    //    }
    //}

    public void PlayVideo()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            videoPlayer.url = videoPath;
            Debug.Log(videoPath);
            videoPlayer.Play();
        }
    }

    public void PauseVideo()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer)
        {
            //string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            //videoPlayer.url = videoPath;
            videoPlayer.Pause();
        }
    }


}

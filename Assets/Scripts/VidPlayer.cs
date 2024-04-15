using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VidPlayer : MonoBehaviour
{
    [SerializeField] string videoFileName;

    // Start is called before the first frame update
    void Start()
    {
        //VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        //PlayVideo();
        //videoPlayer.loopPointReached += CheckOver;
    }

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

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        //videoPlayer.Stop();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Videos : MonoBehaviour
{
    public GameObject Lista, vid1, vid2, playvid1,playvid2;
    public Canvas canvas4, canvas1;
    public Camera camara4, camara1;
    // Start is called before the first frame update
    public void videos()
    {
        camara4.enabled = true;
        canvas4.enabled = true;
        camara1.enabled = false;
        canvas1.enabled = false;

        camara4.GetComponent<AudioListener>().enabled = true;
        camara1.GetComponent<AudioListener>().enabled = false;
    }

    public void ini()
    {
        camara1.enabled = true;
        canvas1.enabled = true;
        camara4.enabled = false;
        canvas4.enabled = false;

        camara1.GetComponent<AudioListener>().enabled = true;
        camara4.GetComponent<AudioListener>().enabled = false;

        vid1.gameObject.SetActive(false);
        vid2.gameObject.SetActive(false);
        Lista.gameObject.SetActive(true);

        AnalyticsResult result = Analytics.CustomEvent("OpenVideos");
        Debug.Log("Analytics result: " + result);
    }

    public void video1()
    {
        var videoPlayer = playvid1.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>(); 
        Lista.gameObject.SetActive(false);
        vid2.gameObject.SetActive(false);
        vid1.gameObject.SetActive(true);
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "ColocacionCan.mp4");
        videoPlayer.Play();
    }

    public void video2()
    {
        var videoPlayer = playvid2.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        Lista.gameObject.SetActive(false);
        vid1.gameObject.SetActive(false);
        vid2.gameObject.SetActive(true);
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "TraccionMan.mp4");
        videoPlayer.Play();
    }

    public void volver()
    {
        vid1.gameObject.SetActive(false);
        vid2.gameObject.SetActive(false);
        Lista.gameObject.SetActive(true);
    }

}

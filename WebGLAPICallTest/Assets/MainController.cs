using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.Networking;
using socket.io;

public class MainController : MonoBehaviour {

    public Text text;

    // Use this for initialization
    void Start() {

    }

    public void OnButtonClick()
    {
        text.text = "Calling API getVRQRPointInfo.do...................";

        UnityEngine.Debug.Log("DataSetPoint.DownloadAndSave()");

        UnityWebRequest webRequest = UnityWebRequest.Get("http://u4d.chahoo.co.kr:8081/inter/getVRQRPointInfo.do");
        webRequest.SetRequestHeader("Content-Type", "application/json");

        StartCoroutine(WebRequest(webRequest));
    }

    private IEnumerator WebRequest(UnityWebRequest request)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        yield return request.Send();

        UnityEngine.Debug.Log(" - DataSetPoint Download Elapsed Time : " + sw.ElapsedMilliseconds.ToString() + "ms");
        text.text = "Download Complete. Elapsed Time : " + sw.ElapsedMilliseconds.ToString() + "ms";
        UnityEngine.Debug.Log(request.downloadHandler.text);
    }
}

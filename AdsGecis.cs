using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class AdsGecis : MonoBehaviour
{

    private InterstitialAd inter;

    public string id_Android = "ca-app-pub-9457289458053843/4826625230";
    public void Start()
    {
        this.Request();
    }

    private void Request()
    {
#if UNITY_ANDROID
            string id = id_Android;
#else

        string id = "unexpected_paltform";

#endif
        this.inter = new InterstitialAd(id);

        this.inter.OnAdClosed += InterstitialClosed;

        AdRequest request = new AdRequest.Builder().Build();
        this.inter.LoadAd(request);
    }

    private void InterstitialClosed(object sender, EventArgs e)
    {
        this.Request();
    }
    public void Show()
    {
        this.inter.Show();
    }
}

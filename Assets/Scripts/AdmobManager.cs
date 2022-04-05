using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class AdmobManager : MonoBehaviour
{
    [SerializeField] GameObject hintsPanel;
    [SerializeField] GameObject hintImage;
    [SerializeField] Sprite[] hints;

    private InterstitialAd interstitialAd;
    private RewardedAd rewardedAd;

    private string interstitialUnitId = "ca-app-pub-3033243931390124/7625839427";
    private string rewadedUnitId = "ca-app-pub-3033243931390124/4560692383";

    private int level;

    private void Awake()
    {
        MobileAds.Initialize(initStatus => { });
    }

    private void OnEnable()
    {
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequestInterstitial = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequestInterstitial);

        rewardedAd = new RewardedAd(rewadedUnitId);
        AdRequest adRequestRewarded = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequestRewarded);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        hintsPanel.SetActive(true);
        hintImage.GetComponent<Image>().sprite = hints[level];
    }

    public void ShowInterstitial()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
        }
    }

    public void ShowRewarded(int curLevel)
    {
        level = curLevel;

        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
    }
}

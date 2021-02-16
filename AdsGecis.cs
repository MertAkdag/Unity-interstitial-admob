using UnityEngine;
using UnityEngine.Advertisements;
public class AdsGecis : MonoBehaviour
{

    public string GameID = "gameid";
    public string InterstitialPlacementID = "video";

    private bool interstitialGosterilecek = false;

    void Start()
    {
        Advertisement.Initialize(GameID, testModu);
    }

    void Update()
    {
        if (interstitialGosterilecek)
        {
            float sayi;
            sayi = Random.Range(0, 6);

            if (Advertisement.IsReady(InterstitialPlacementID) && sayi == 3)
            {
                Advertisement.Show(InterstitialPlacementID);

                interstitialGosterilecek = false;
            }
        }
    }

    public void InterstitialGoster()
    {
        interstitialGosterilecek = true;
    }
}

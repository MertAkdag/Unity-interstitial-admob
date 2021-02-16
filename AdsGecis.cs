using UnityEngine;
using UnityEngine.Advertisements;
public class AdsGecis : MonoBehaviour
{
    public string GameID = "gameid";
    public string InterstitialPlacementID = "video";
    public bool testModu = true;
    float sayi;
    private bool interstitialGosterilecek = false;

    void Start()
    {
        sayi = Random.Range(0, 4);
        Debug.Log(sayi);
        Advertisement.Initialize(GameID, testModu);
        InterstitialGoster();
    }

    void Update()
    {
        if (interstitialGosterilecek)
        {
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

using TMPro;
using UnityEngine;

public class GUItext : MonoBehaviour
{
    public TextMeshProUGUI textResource;
    public TextMeshProUGUI textCoins;

    private void Update()
    {
        textResource.text ="Resource: " + PlayerController.Resource.ToString();
        textCoins.text ="Coins: " + PlayerController.Coins.ToString();
    }
}

using TMPro;
using UnityEngine;

public class ResourceText : MonoBehaviour
{
    public TextMeshProUGUI textResource;

    private void Update()
    {
        textResource.text ="Resource: " + PlayerController.Coins.ToString();
    }
}

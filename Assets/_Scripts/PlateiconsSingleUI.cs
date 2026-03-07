using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlateiconsSingleUI : MonoBehaviour
{

    [SerializeField] private Image image;
    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO)
    {
        image.sprite = kitchenObjectSO.sprite;
    }
}

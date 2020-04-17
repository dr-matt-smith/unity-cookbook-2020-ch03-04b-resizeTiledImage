using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerInventory))]
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image iconStarsYellow;

    public void OnChangeStarTotal(int starTotal)
    {
        float newWidth = 100 * starTotal;
        iconStarsYellow.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, newWidth);
    }
}

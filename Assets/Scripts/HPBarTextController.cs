using UnityEngine;
using TMPro;

public class HpBarTextController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;

    public void SliderChange(float value)
    {
        float localValue = value;
        sliderText.text = "CAN : " + localValue.ToString("0");
    }
}

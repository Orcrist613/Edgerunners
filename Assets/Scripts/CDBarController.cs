using UnityEngine;
using TMPro;

public class CDBarController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText;
    public void Awake()
    {
        sliderText.text = "2s";
    }
    public void SliderChange2(float value)
    {
        float localValue = value;
        sliderText.text = localValue.ToString("") + "s";
    }
}

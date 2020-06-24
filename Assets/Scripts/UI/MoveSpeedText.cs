using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoveSpeedText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moveSpeedText;
    [SerializeField] private Slider _moveSpeedSlider;

    private void OnEnable()
    {
        _moveSpeedSlider.onValueChanged.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        _moveSpeedSlider.onValueChanged.RemoveListener(ChangeValue);
    }

    private void ChangeValue(float value)
    {
        _moveSpeedText.text = $"Move Speed is {value}";
    }
}
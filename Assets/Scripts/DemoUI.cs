using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Display to show when the color will change
public class DemoUI : MonoBehaviour
{
    [SerializeField] private TMP_Text TimerText;
    [SerializeField] private Countdown Countdown;

    // Note: A second is added so that it does not display 0 seconds remaining
    private void Update()
    {
        TimerText.text = "Time until color change: " + (int)(0.99f + Countdown.GetTimeRemaining()) + " seconds";
    }
}

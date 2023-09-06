using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Countdown that triggers an event that updates other elements in the game
public class Countdown : MonoBehaviour
{
    public static event Action<Color> OnTimerEnd;
    [SerializeField] private Color CurrentColor, MainColor, AltColor;
    [SerializeField] private float TimerDelay, TimeElapsed;

    private void Start()
    {
        OnTimerEnd += ToggleColor;
    }

    private void Update()
    {
        TimeElapsed += Time.deltaTime;
        if (TimeElapsed >= TimerDelay)
        {
            OnTimerEnd?.Invoke(CurrentColor == MainColor ? AltColor : MainColor);
            TimeElapsed = 0;
        }
    }

    private void ToggleColor(Color newColor)
    {
        CurrentColor = newColor;
    }

    public float GetTimeRemaining()
    {
        return TimerDelay - TimeElapsed;
    }
}

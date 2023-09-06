using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Platform that toggles on and off with the color
public class AlternatingPlatforms : MonoBehaviour
{
    [SerializeField] private Color ActiveColor, InactiveColor;

    private void Start()
    {
        Countdown.OnTimerEnd += ActivateWithColor;
    }

    public void ActivateWithColor(Color color)
    {
        GetComponent<BoxCollider2D>().enabled = color == ActiveColor;
        GetComponent<SpriteRenderer>().color = color == ActiveColor ? ActiveColor : InactiveColor;
    }
}

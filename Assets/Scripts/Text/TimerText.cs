using UnityEngine;
using TMPro;
using System;

public class TimerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    void Update(){
        timerText.text = "Time: " + Math.Round(Timer.getTime(), 1) + " seconds";
    }
}

using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    void Update(){
        timerText.text = "Time: " + Timer.getTime() + " seconds";
    }
}

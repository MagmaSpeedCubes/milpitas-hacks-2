using UnityEngine;

public class Timer : MonoBehaviour
{

    private static float seconds = 0f;
    private static Timer instance;
    private static bool active = false;

    void Start()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(this);
        }
    }

    void Update()
    {
        if(active){
            seconds += Time.deltaTime;
        }
    }

    public static void startTimer(){
        active = true;
    }

    public static void stopTimer(){
        active = false;
    }

    public static void resetTimer(){
        seconds = 0;
    }

    public static float getTime(){
        return seconds;
    }
}

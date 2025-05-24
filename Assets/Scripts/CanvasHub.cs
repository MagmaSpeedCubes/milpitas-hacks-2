using UnityEngine;
using System.Collections.Generic;

public class CanvasHub : MonoBehaviour
{

    [SerializeField] private List<Canvas> canvasList;
    [SerializeField] private Canvas titleScreen;
    private static CanvasHub instance;

    void Awake(){
        if(instance==null){
            instance = this;
        }
    }

    void Start(){
        showCanvas(titleScreen);
    }

    public static void showCanvas(Canvas canvas){
        foreach(Canvas c in instance.canvasList){
            c.enabled = false;
        }
        canvas.enabled = true;
    }


}

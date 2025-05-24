using UnityEngine;

public class CanvasButton : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public void onClick(){
        CanvasHub.showCanvas(canvas);
    }
}

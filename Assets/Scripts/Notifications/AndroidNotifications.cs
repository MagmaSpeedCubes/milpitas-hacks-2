using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine.Android;

public class AndroidNotifications : MonoBehaviour
{
    
    public void RequestAuthorization(){
        if(!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS")){
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }
    }

    public void RegisterNotificationChannel(){
        var channel = new AndroidNotificationChannel{
            Id = "default_channel",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "eeee"
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    public void SendNotification(string title, string text, int fireTimeInHours){
        var notification = new AndroidNotification();
        notification.Title = title;
        notification.Text = text;
        notification.FireTime = System.DateTime.Now.AddHours(0);
        notification.SmallIcon = "icon_0";
        notification.LargeIcon = "icon_0";

        AndroidNotificationCenter.SendNotification(notification, "default_channel"); 
    }

    
}

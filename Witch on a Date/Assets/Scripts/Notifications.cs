using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Notifications : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Премахни нотификации, които вече са се показали
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        // Създавам канал по който да се изпращат нотификациите
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        // notification е променлива за нотификации
        var notification = new AndroidNotification();
        // Съобщението, което ще се изпише на нотификацията:
        // Заглавие
        notification.Title = "Witch on a Date"; 
        // Текст
        notification.Text = "Help me look young on my date";
        // Изпрати нотификацията 15 секунди след извикването на тази функция
        notification.FireTime = System.DateTime.Now.AddSeconds(1);

        // Изпращаме нотификацията на зададен канал
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        // Ако скрипта върви и вече е изпратил нотификация, спри ново изпращане
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

}

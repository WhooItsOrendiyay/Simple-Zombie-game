using UnityEngine;

namespace Project.Managers
{
    [System.Serializable]
    public class NotificationProperties
    {
        public string notifName = null;
        [Space]
        public string notifTitle = "Notification Title";
        [TextArea(1,3)]
        public string notifContents = "Notification Contents";
    }
}

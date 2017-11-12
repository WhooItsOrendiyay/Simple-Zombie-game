using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Managers
{
    public class UIManager : MonoBehaviour
    {
        [Header("UI Elements")]
        public List<UIProperties> uiElements = new List<UIProperties>();

        [Header("Notifications")]
        public List<NotificationProperties> notifications = new List<NotificationProperties>();
        public Text notifTitleObject = null;
        public Text notifContentsObject = null;


        public void EnableUIElement(string elementName)
        {
            for(int i = 0; i < uiElements.Count; i++)
            {
                if(uiElements[i].elementName == elementName)
                {
                    uiElements[i].elementObject.SetActive(true);
                }
            }
        }

        public void DisableUIElement(string elementName)
        {
            for (int i = 0; i < uiElements.Count; i++)
            {
                if (uiElements[i].elementName == elementName)
                {
                    uiElements[i].elementObject.SetActive(false);
                }
            }
        }
    }
}

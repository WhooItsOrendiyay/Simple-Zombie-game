using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Managers
{
    [System.Serializable]
    public class ObjectProperties
    {
        public string objectName = null;
        public ObjectType objectType = ObjectType.Empty;
        [Space]
        public GameObject objectGameObject = null;
    }
}

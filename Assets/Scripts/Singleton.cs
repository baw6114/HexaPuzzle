using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Singleton : MonoBehaviour
    {
        public Singleton instance;

        private void Awake()
        {
            if (!instance)
            {
                instance = this;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
        public float Lifetime = 5f;
        private void Start()
        {
            Destroy(gameObject, Lifetime);
        }
    
}

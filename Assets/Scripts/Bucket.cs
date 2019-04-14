using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneHundredBalls
{
    public class Bucket : MonoBehaviour
    {
        public float speed = 5f;
        public Vector2 direction = Vector2.right;

        void Update()
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;    
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.name.Contains("Ball"))
            {
                other.transform.SetParent(transform);
            }
        }
    }
}
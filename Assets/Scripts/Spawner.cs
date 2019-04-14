using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneHundredBalls
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public float length = 5;
        public float spawnDelay = 1f;

        void OnDrawGizmos()
        {
            if (Application.isEditor)
            {
                float halfLength = length * 0.5f;
                Vector3 pos = transform.position;
                Vector3 right = transform.right;
                Vector3 start = pos - right * halfLength;
                Vector3 end = pos + right * halfLength;
                Gizmos.DrawLine(start, end);
            }
        }

        public void Create(GameObject objectToSpawn)
        {
            GameObject clone = Instantiate(objectToSpawn);

            float halfLength = length * 0.5f;
            Vector3 pos = transform.position; // Default to zero
            Vector3 right = transform.right;
            pos += right * Random.Range(-halfLength, halfLength);
            
            clone.transform.position = pos;
        }

        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(spawnDelay);

            Create(prefab);

            StartCoroutine(Spawn());
        }

        void Start()
        {
            StartCoroutine(Spawn());
        }
    }
}
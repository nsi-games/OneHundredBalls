using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneHundredBalls
{
    public class Paddle : MonoBehaviour
    {
        private Animator anim;

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("IsOpened", true);
            }else
            {
                anim.SetBool("IsOpened", false);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace joao
{
    public class Dice : MonoBehaviour
    {
        [Header("Config")]
        public static Vector3 diceVelocity;

        [Header("Imports")]
        public static Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            diceVelocity = rb.velocity;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                float dirx = Random.Range(0, 500);
                float diry = Random.Range(0, 500);
                float dirz = Random.Range(0, 500);

                transform.position = new Vector3(0, 2, 0);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50);
                rb.AddTorque(dirx, diry, dirz);
            }
        }
    }
}

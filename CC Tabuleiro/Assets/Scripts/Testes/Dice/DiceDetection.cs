using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace joao
{
    public class DiceDetection : MonoBehaviour
    {
        [Header("Config")]
        public Vector3 diceVelocity;

        private void FixedUpdate()
        {
            diceVelocity = Dice.diceVelocity;
        }

        private void OnTriggerStay(Collider col)
        {
            if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
            {
                switch (col.gameObject.name)
                {
                    case "1":
                        PlayerMove.pecasIndex += 1;
                        break;
                    case "2":
                        PlayerMove.pecasIndex += 2;
                        break;
                    case "3":
                        PlayerMove.pecasIndex += 3;
                        break;
                    case "4":
                        PlayerMove.pecasIndex += 4;
                        break;
                    case "5":
                        PlayerMove.pecasIndex += 5;
                        break;
                    case "6":
                        PlayerMove.pecasIndex += 6;
                        break;
                }
            }
        }
    }
}

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
                        DiceText.number = "1";
                        break;
                    case "2":
                        DiceText.number = "2";
                        break;
                    case "3":
                        DiceText.number = "3";
                        break;
                    case "4":
                        DiceText.number = "4";
                        break;
                    case "5":
                        DiceText.number = "5";
                        break;
                    case "6":
                        DiceText.number = "6";
                        break;
                }
            }
        }
    }
}

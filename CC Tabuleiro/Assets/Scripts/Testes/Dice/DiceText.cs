using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace joao
{
    public class DiceText : MonoBehaviour
    {
        [Header("Imports")]
        public static TextMeshProUGUI text;

        public static string number;

        void Start()
        {
            text = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            text.text = number;   
        }
    }

}
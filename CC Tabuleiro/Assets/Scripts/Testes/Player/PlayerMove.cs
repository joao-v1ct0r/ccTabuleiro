using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Config")]
    public GameObject[] pecas;

    public static int pecasIndex = 0;

    void Start()
    {
        transform.position = pecas[0].transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(pecas[pecasIndex].transform.position.x, 1, pecas[pecasIndex].transform.position.z);
    }
}

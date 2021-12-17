using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInformation : MonoBehaviour
{

    GameObject health;

    private void Awake()
    {
        health.GetComponent<DLLHealth>().playerHealth = 10;
    }

}

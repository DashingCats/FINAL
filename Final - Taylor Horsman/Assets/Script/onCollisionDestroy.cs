using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionDestroy : MonoBehaviour
{
    public GameObject enemy;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(enemy);
    }
}

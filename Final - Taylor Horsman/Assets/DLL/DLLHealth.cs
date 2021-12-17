using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;

public class DLLHealth : MonoBehaviour
{

    public int playerHealth;

    [DllImport("DLL")]
    static extern int GetHealth();
    
    [DllImport("DLL")]
    static extern int SetHealth(int health);

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUIScript : MonoBehaviour
{

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Nouvelle Vague"))
        {
            FindObjectOfType <WaveManager>().StartWave();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMob : Mob
{
    private void Update()
    {

        Debug.Log(_mobElement.ToString());  
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.02f);
    }
}

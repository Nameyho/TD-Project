using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMob : Mob
{
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 0.02f);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private FixedJoint f;
    
    private void Start()
    {
        f = GetComponent<FixedJoint>();
    }

    public void Break()
    {
        if (f == null) return;
        f.breakForce = 0;
    }
}

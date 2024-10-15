using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    public override bool Decide()
    {
       return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasPlayerEnter = true;
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        hasPlayerEnter = false;
    }
}
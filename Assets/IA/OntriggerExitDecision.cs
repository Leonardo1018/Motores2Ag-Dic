using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerExitDecision : AIDecision
{
    private bool hasPlayerExit;

    public override void Initialization()
    {
        base.Initialization();
        hasPlayerExit = false;
    }
    public override bool Decide()
    {
        return hasPlayerExit;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && _brain.Target != null)
        {
            _brain.Target = null;
            hasPlayerExit = true;
         
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        hasPlayerExit = false;
    }
}

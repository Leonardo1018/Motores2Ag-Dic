using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnimationAction : AIAction
{
    // Start is called before the first frame update
    public override void PerformAction()
    {
        
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetBool("IsFollowing", false);
    }
}

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
            _brain.Target = other.transform;
            if (TryGetComponent<ReturnOriginAction>(out ReturnOriginAction returnOriginComponent)) 
            {
                returnOriginComponent.originPos = transform.position;            
            }
            if (TryGetComponent<DistanceDecision>(out DistanceDecision distanceDecisionComponent))
            {
                distanceDecisionComponent.originPos = transform.position;
            }
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        hasPlayerEnter = false;
    }
}

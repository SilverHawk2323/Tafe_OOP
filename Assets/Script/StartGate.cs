using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class StartGate : TriggerZone
{
    public override void Activate(Collider collider)
    {
        //change colour of marble
        ChangeColour(collider.GetComponent<Renderer>());

        if(Timer.instance != null)
        {
            Timer.instance.StartTimer();
        }
        
    }
}

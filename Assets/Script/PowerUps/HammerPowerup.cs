using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Hammer")]
public class HammerPowerup : Powerups
{
    public override void UsePowerup(Rigidbody rb)
    {
        Debug.Log("Hammer Time");
    }
}

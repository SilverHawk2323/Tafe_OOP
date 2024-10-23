using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/boost")]
public class BoostPowerup : Powerups
{
    public override void UsePowerup(Rigidbody rb)
    {
        rb.AddRelativeForce(Vector3.back * power, ForceMode.VelocityChange);
    }
}

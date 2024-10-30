using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Boost")]
public class BoostPowerup : Powerups
{
    public override void UsePowerup(Rigidbody rb)
    {
        Debug.Log("Boost");
        rb.AddForce(rb.velocity.normalized * power, ForceMode.VelocityChange);
    }
}

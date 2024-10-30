using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Hammer")]
public class HammerPowerup : Powerups
{
    public LayerMask mask;
    public float radius = 8f;
    public override void UsePowerup(Rigidbody rb)
    {
        Debug.Log("Hammer");
        //int mask = 1 << LayerMask.NameToLayer("Marble");
        Collider [] neighbors = Physics.OverlapSphere(rb.transform.position, radius, mask);
        Debug.Log(neighbors.Length);

        foreach (Collider col in neighbors)
        {
            if (col.transform == rb.transform) continue;
            col.attachedRigidbody.AddExplosionForce(power, rb.position, radius);
        }



        Debug.Log("Hammer Time");
    }
}

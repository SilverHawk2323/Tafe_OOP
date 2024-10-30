using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "PowerUps/Glue")]
public class GluePower : Powerups
{
    public LayerMask mask;
    public float radius;
    public override void UsePowerup(Rigidbody rb)
    {
        Debug.Log("Glue");
        Collider[] neighbors = Physics.OverlapSphere(rb.transform.position, radius, mask);
        Debug.Log(neighbors.Length);

        FindAnyObjectByType<ItemBox>().StartCoroutine(GlueTimer(neighbors, rb));

        
    }

    IEnumerator GlueTimer(Collider[] neighbors, Rigidbody rb)
    {
        float startTime = Time.time;
        while (startTime + duration > Time.time)
        {
            foreach (Collider col in neighbors)
            {
                if (col.transform == rb.transform) continue;
                float reduction = Mathf.Clamp01(Mathf.InverseLerp(100, 0, power));
                col.attachedRigidbody.velocity *= reduction;
            }
            yield return new WaitForFixedUpdate();
        }
        
        
    }

}

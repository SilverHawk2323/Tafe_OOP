using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : TriggerZone, I_Clickable
{
    public Powerups[] powerup;

    public float speed = 3f;
    public int totalPUChances;

    float cooldown = 0f;

    public void Start()
    {
        totalPUChances = 0;
        foreach (Powerups powerup in powerup)
        {
            totalPUChances += powerup.chance;
        }
    }

    public override void Activate(Collider collider)
    {

        if (cooldown > 0f)
        {
            return;
        }
        Powerups chosenPU = null;
        int randomPU = Random.Range(0, totalPUChances);
        foreach (Powerups powerup in powerup)
        {
            randomPU -= powerup.chance;
            if(randomPU < 0)
            {
                chosenPU = powerup;
                break;
            }
        }
        

        if (chosenPU == null) return;
        chosenPU.UsePowerup(collider.attachedRigidbody);
        cooldown = chosenPU.cooldown;
    }

    public void OnClick()
    {
        StartCoroutine(Spin());
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        cooldown -= Time.deltaTime;
    }

    IEnumerator Spin()
    {
        speed += 50f;
        //transform.Rotate(Vector3.up, speed * Time.deltaTime);
        yield return new WaitForSeconds(2f);
        speed -= 50f;
    }
}

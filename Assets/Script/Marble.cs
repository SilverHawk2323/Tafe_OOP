using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour, I_Clickable
{
    Renderer renderer;
    public Powerups[] powerup;

    public float speed = 3f;
    public int totalPUChances;

    float cooldown = 0f;
    void Awake() 
    { 
        renderer = GetComponent<Renderer>(); 
    }
    private void Start()
    {
        totalPUChances = 0;
        foreach (Powerups powerup in powerup)
        {
            totalPUChances += powerup.chance;
        }
    }
    private void Update()
    {
        cooldown -= Time.deltaTime;
    }
    public void OnClick()
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
            if (randomPU < 0)
            {
                chosenPU = powerup;
                break;
            }
        }


        if (chosenPU == null) return;
        chosenPU.UsePowerup(GetComponent<Collider>().attachedRigidbody);
        cooldown = chosenPU.cooldown;
    }

    public void ChangeColour()
    {
        renderer.material.color = Color.magenta;
    }
}

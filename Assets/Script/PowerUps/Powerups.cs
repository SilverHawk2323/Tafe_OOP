using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Powerups : ScriptableObject
{
    public int chance = 1;
    public float cooldown = 1f;
    public float duration = 0f;
    public float power = 1f;
    public abstract void UsePowerup(Rigidbody rb);
}

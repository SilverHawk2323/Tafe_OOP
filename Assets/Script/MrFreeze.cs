using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrFreeze : MonoBehaviour, I_Clickable
{
    [SerializeField] PhysicMaterial _Material;
    Collider _Collider;
    Renderer renderer;
    Color originalColor;
    PhysicMaterial originalMaterial;
    private void Awake()
    {
        _Collider = GetComponent<Collider>();
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
        originalMaterial = _Collider.material;
    }

    public void OnClick()
    {
        if (_Collider.material == originalMaterial)
        {
            _Collider.material = _Material;
            renderer.material.color = Color.cyan;
        }
        else
        {
            _Collider.material = originalMaterial;
            renderer.material.color = originalColor;
        }
        
    }
}

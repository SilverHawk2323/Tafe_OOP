using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour
{
    [SerializeField] Camera _mc;
    private void Awake()
    {
        if (_mc == null)
        {
            _mc = Camera.main ? Camera.main : GetComponent<Camera>();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _mc.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                I_Clickable clickedObject = hit.transform.gameObject.GetComponent<I_Clickable>();

                if (clickedObject != null)
                {
                    clickedObject.OnClick();
                }
            }
        }
    }
}

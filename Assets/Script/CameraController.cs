using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public List<Marble> marbles = new List<Marble>();
    //Marble[] marblesArray;

    Vector3 offset = new Vector3(5f, 10f, 5f);

    private void Start()
    {
        marbles = FindObjectsOfType<Marble>().ToList();
        marbles = marbles.OrderBy(n => n.transform.position.y).ToList();
    }

    private void Update()
    {
        Vector3 avPosition = Vector3.zero; //= (marbles[0].transform.position +marbles[1].transform.position + marbles[2].transform.position) / 3;
        /* if (Vector3.Distance(marbles[0].transform.position, marbles[1].transform.position) < 5f)
         {
             avPosition = (marbles[0].transform.position + marbles[1].transform.position + marbles[2].transform.position) / 3;
         }
         else
         {
             avPosition = marbles[0].transform.position;
         }
         transform.position = avPosition + offset;
         transform.LookAt(avPosition);*/
        for (int i = 0; i < marbles.Count; i++)
        {
            avPosition += marbles[i].transform.position;
        }
        avPosition /= marbles.Count;
        //transform.position = avPosition + offset;
        //transform.LookAt(avPosition);
        transform.position = marbles[0].transform.position + offset;
        transform.LookAt(marbles[0].transform.position);
    }

    private void FixedUpdate()
    {
       marbles = marbles.OrderBy(n => n.transform.position.y).ToList();
    }
}

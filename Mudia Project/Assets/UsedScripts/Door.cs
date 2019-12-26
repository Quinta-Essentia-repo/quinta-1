using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject door1,door2;
    public bool vertical;
    

    private void OnTriggerEnter(Collider player)
    {
        if (vertical)
        {
            door1.transform.position += new Vector3(0, 0, 3);
            door2.transform.position -= new Vector3(0, 0, 3);
        }
        else
        {
            door1.transform.position += new Vector3(3, 0, 0);
            door2.transform.position -= new Vector3(3, 0, 0);
        }
    }
    private void OnTriggerExit(Collider player)
    {

        if (vertical)
        {
            door2.transform.position += new Vector3(0, 0, 3);
            door1.transform.position -= new Vector3(0, 0, 3);
        }
        else
        {
            door2.transform.position += new Vector3(3, 0, 0);
            door1.transform.position -= new Vector3(3, 0, 0);
        }
    }
}

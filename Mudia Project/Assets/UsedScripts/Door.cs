using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    GameObject door1,door2;
    

    private void OnTriggerEnter(Collider player)
    {
        door1.transform.position += new Vector3(3, 0, 0);
        door2.transform.position -= new Vector3(3, 0, 0);
    }
    private void OnTriggerExit(Collider player)
    {
        door2.transform.position += new Vector3(3, 0, 0);
        door1.transform.position -= new Vector3(3, 0, 0);
    }
}

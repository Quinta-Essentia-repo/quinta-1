using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DangerZone : MonoBehaviour
{
    
    public bool Combat;
    public float EnemyNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == GameObject.FindGameObjectWithTag("Enemy"))
        {
            EnemyNumber += 1;
            
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == GameObject.FindGameObjectWithTag("Enemy"))
        {
            EnemyNumber -= 1;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyNumber >= 1)
        {
            Combat = true;
        }
        else
        {
            Combat = false;
        }
    }
}

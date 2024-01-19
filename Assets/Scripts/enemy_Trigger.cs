using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Trigger : MonoBehaviour
{
    public Enemy_Move enemumove;

    public bool iszut = true;

    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if(iszut)
            {
                enemumove.setnav(other.transform.position);
                enemumove.isnav = false;
                enemumove.animator.SetBool("run", true);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemumove.isnav = true;
            enemumove.animator.SetBool("run", false);          
            enemumove.setnav();
        }
    }




}

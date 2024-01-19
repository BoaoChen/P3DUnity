using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Over : MonoBehaviour
{
   public Canvas_Manager canvas_Manager;
    public enemy_Trigger triggerscript;
   public Enemy_Move enemy_;
    public string over_str;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvas_Manager.set_Mina(over_str);
            canvas_Manager.gameObject.SetActive(true);
            triggerscript.iszut = false;
            enemy_.animator.SetTrigger("stop");
        }
    }

}

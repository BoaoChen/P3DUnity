using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class men_Trigger : MonoBehaviour
{
    public Animation men_animation;
    float timea;
    public string animaitionname;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        
            men_animation[animaitionname].speed = 1;
            men_animation.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timea = men_animation[animaitionname].time;
            men_animation[animaitionname].time = timea;
            men_animation[animaitionname].speed = -1;
            men_animation.Play();
        }
    }
}

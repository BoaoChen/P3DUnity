using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;





public class Enemy_Move : MonoBehaviour
{
    private NavMeshAgent navmeshagent;
    [SerializeField]
    private List<Transform> poss=new List<Transform>();
    [HideInInspector]
    public int Posindex = 0;
    [SerializeField]
    public bool isnav = true;
    public Animator animator;

    private void Start()
    {
        navmeshagent = GetComponent<NavMeshAgent>();
        navmeshagent.SetDestination(setvec(ref Posindex));
    }

    private void Update()
    {
        if(isnav)
        {
            if (navmeshagent.remainingDistance <= 0.5f)
            {
                navmeshagent.SetDestination(setvec(ref Posindex));
            }
        }
      
    }


    Vector3 setvec(ref int index)
    {
        index = (index += 1) % poss.Count;
        return poss[index].position;
    }
    public void setnav()
    {
        navmeshagent.SetDestination(setvec(ref Posindex));
    }
    public void setnav(Vector3 ver)
   {    
      navmeshagent.SetDestination(ver);
   }
}

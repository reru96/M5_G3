using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform warpPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out NavMeshAgent agent))
        {
            agent.Warp(warpPos.position);
        }
    }
}

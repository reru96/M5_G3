using System.Collections;
using System.Collections.Generic;
using Unity.AI;
using UnityEngine;
using UnityEngine.AI;

public class AgentTarget : MonoBehaviour
{
    private Camera cam;
    private NavMeshAgent agent;
    [SerializeField] private float _angularSpeed;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (move == Vector3.zero)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    agent.angularSpeed = _angularSpeed;
                    agent.SetDestination(hit.point);    
                }
            }
        }
        
    }
}

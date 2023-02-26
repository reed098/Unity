using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alt_Character : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _Navmesh;

    void Start()
    {
        _Navmesh = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;
    }

    void LateUpdate()
    {
        _Navmesh.SetDestination(Target.transform.position); // Navmesh e pozisyon böyle atıyoruz.
    }
}

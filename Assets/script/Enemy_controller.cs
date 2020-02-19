using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_controller : MonoBehaviour {
    public float lookRadius = 10.0f;
    Transform target;
        NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
//        Quaternion lookRotation= Quaternion.LookRotation(new Vector3(di))
    }
}

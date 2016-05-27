using UnityEngine;
using System.Collections;

public class direction : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
            agent.SetDestination(target.position);
        else agent.ResetPath();

	}
}

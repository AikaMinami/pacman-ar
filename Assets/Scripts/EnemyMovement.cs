using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
    public NavMeshAgent agent;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosition, out var hitInfo))
            {
                    agent.SetDestination(hitInfo.point);
            }
        }

        // GameObject go = new GameObject("Target");
        // Vector3 sourcePostion = new Vector3( 0.300536f, -0.9634861f, 7.73f );//The position you want to place your agent
        // NavMeshHit closestHit;
        // if( NavMesh.SamplePosition(this.gameObject.transform.position, out closestHit, 500, 1 ) ){
        // this.gameObject.transform.position = closestHit.position;
        // // this.gameObject.AddComponent<NavMeshAgent>();
        // // this.gameObject.GetComponent<NavMeshAgent>().SetDestination(new Vector3(0.300536f, -0.09634861f, -7.61f));
        // agent.SetDestination(new Vector3(0.300536f, -0.9634861f, 7.73f));
        // //TODO
        // }
        // else{
        // Debug.Log("...");
        // }
    }
}
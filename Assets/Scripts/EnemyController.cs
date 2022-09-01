using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform playerTransform;

    public SceneManagers sceneManagers;
    public bool isMoved = false;
    void Start()
    {
        isMoved = false;  
    }

    private void Update() {
        if(sceneManagers.state == "ingame" && isMoved)
        {
            Debug.Log("play");
            agent.isStopped = false;
            agent.SetDestination(playerTransform.position);
        } else {
            agent.isStopped = true;
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            sceneManagers.setGameOver();
        }
    }

}

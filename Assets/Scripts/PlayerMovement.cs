using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private string stateDirection;
    public bool isGameOver;
    public bool isGameStarted;
    void Start()
    {
        // stateDirection = "right";
        isGameOver = false;
        isGameStarted = false;
    }
    // 
    // Update is called once per frame
    void Update()
    {
        Debug.Log(stateDirection);
        if(!isGameOver && isGameStarted)
        {
            movePlayer(stateDirection);
            if(Input.GetKeyDown("d")){
                stateDirection = "right";
            } 
            if(Input.GetKeyDown("a")){
                stateDirection = "left";
            } 
            if(Input.GetKeyDown("w")){
                stateDirection = "up";
            } 
            if(Input.GetKeyDown("s")){
                stateDirection = "down";
            }
        } else {
            transform.position += Vector3.zero;
        }
    }

    void movePlayer(string state)
    {
        switch(state){
            case "up":
                // transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);
                transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);
                break;
            case "down":
                // transform.position -= new Vector3(0, 0, movementSpeed * Time.deltaTime);
                transform.position -= new Vector3(0, movementSpeed * Time.deltaTime, 0);
                break;
            case "left":
                transform.position -= new Vector3(movementSpeed * Time.deltaTime, 0, 0);
                break;
            case "right":
                transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
                break;
            default:
                transform.position += new Vector3(0,0,0);
                break;
        }
    }

    public void setState(string states) {
        stateDirection = states;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("wall"))
        {
            stateDirection = "";
        }
    }

    public void onGameOver()
    {
        isGameOver = true;
    }
}

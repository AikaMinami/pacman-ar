using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBaker : MonoBehaviour {

    public NavMeshSurface surfaces;
    Vector3 newScale;

    private void Start() {
        surfaces.BuildNavMesh();
        
    }
    void Update () 
    {      
        newScale = this.gameObject.transform.localScale;
    }

    public void SetScaleAndBuild()
    {
        surfaces.size = newScale;  
        surfaces.BuildNavMesh();      
    }
}
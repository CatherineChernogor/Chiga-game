using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingScript : MonoBehaviour {
    public bool flag=false;

void OnTriggerEnter(Collider other){
        flag = true;
    }
    void OnTriggerExit(Collider other ){
        flag = false;
    }
}
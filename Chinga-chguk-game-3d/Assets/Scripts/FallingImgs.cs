using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingImgs : MonoBehaviour {

    public GameObject Pics;
    private float Speed = 230f;
    
    void Update () {
        Pics.transform.Translate (Vector3.down * Speed * Time.deltaTime);
    }
}
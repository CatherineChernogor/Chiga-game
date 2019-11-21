using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour {

    public GameObject[] Buttons;

    void Update () {

        if (Input.GetKey (KeyCode.A)) {
            print ("A pressed");
            //print(Buttons[0].GetCompanent<Image>);

        }
        if (Input.GetKey (KeyCode.S)) {
            print ("s pressed");
        }
        if (Input.GetKey (KeyCode.K)) {
            print ("k pressed");
        }
        if (Input.GetKey (KeyCode.L)) {
            print ("L pressed");
        }

    }
        

}
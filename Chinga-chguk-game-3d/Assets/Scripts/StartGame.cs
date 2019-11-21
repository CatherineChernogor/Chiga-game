using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    
    public GameObject GamePanel;
    public GameObject MenuPanel;
    public GameObject Moving;
    public GameObject Chingu;

    public void BtnPress () {

        MenuPanel.SetActive (false);
        GamePanel.SetActive (true);
        Chingu.SetActive(false);
        Moving.transform.position = new Vector3(600,700, 0);

    }
}
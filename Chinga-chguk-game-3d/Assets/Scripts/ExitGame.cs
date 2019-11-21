using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {
    public GameObject GamePanel;
    public GameObject MenuPanel;

    public void BTNPress () {
        MenuPanel.SetActive (true);
        GamePanel.SetActive (false);
    }
}
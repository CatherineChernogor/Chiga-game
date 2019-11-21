using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    public GameObject GamePanel;
    public GameObject MenuPanel;

    public Text scoreText;
  

    void Start () {
        InvokeRepeating ("RunTimer", 1, 1);
        
    }

    void RunTimer () {
        
        scoreText.text = (int.Parse (scoreText.text) - 1).ToString ();
        if (int.Parse (scoreText.text) <= 0) {
            MenuPanel.SetActive (true);
            GamePanel.SetActive (false);
            scoreText.text = "110";
        }
    }
}
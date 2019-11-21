using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEvent : MonoBehaviour
{
    public Text Score;
    public GameObject LeftChingu;
    public int comboCounter = 1;
    public float time = 50f;
    public GameObject[] Buttons;
    public int localScore;

bool flag = false;
    public void Update()
    {

        if (Input.GetKey(KeyCode.A) && Buttons[0].GetComponent<TouchingScript>().flag)
        {
            localScore++;
            comboCounter++;
        }
        if (Input.GetKey(KeyCode.S) && Buttons[1].GetComponent<TouchingScript>().flag)
        {
            localScore++;
            comboCounter++;
        }
        if (Input.GetKey(KeyCode.K) && Buttons[2].GetComponent<TouchingScript>().flag)
        {
            localScore++;
            comboCounter++;
        }
        if (Input.GetKey(KeyCode.L) && Buttons[3].GetComponent<TouchingScript>().flag)
        {
            localScore++;
            comboCounter++;
        }

        Score.text = (localScore / 5).ToString();

        if (comboCounter % 400 == 0)
        {
            flag = true;
            LeftChingu.SetActive(true);
            if (time <= 0)
            {
                LeftChingu.SetActive(false);
                time = 50f;
                flag = false;
            }
        }
        else LeftChingu.SetActive(false);

        if (flag)
        {
            time -= 1;

        }

    }

}





/*
        if (!Input.GetKey (KeyCode.A) && Buttons[0].GetComponent<TouchingScript> ().flag) {
            comboCounter = 0;
        }
        if (!Input.GetKey (KeyCode.S) && Buttons[1].GetComponent<TouchingScript> ().flag) {
            comboCounter = 0;
        }
        if (!Input.GetKey (KeyCode.K) && Buttons[2].GetComponent<TouchingScript> ().flag) {
            comboCounter = 0;
        }
        if (!Input.GetKey (KeyCode.L) && Buttons[3].GetComponent<TouchingScript> ().flag) {
            comboCounter = 0;
        }
*/
/*

public void CountScore () {
            Score.text = (int.Parse (Score.text) + 1).ToString ();
        }

*/

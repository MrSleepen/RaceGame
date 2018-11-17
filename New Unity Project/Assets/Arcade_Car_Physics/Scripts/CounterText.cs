using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CounterText : MonoBehaviour {
    public Text CounterText1;
    public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.Timer < 1)
        {
            timer = GameManager.Instance.Timer;
            CounterText1.text = "Ready";
        }
        else if (GameManager.Instance.Timer > 1 && GameManager.Instance.Timer <2)
        {
            timer = GameManager.Instance.Timer;
            CounterText1.text = "Set";
        }
        else if (GameManager.Instance.Timer > 2 && GameManager.Instance.Timer < 3)
        {
            timer = GameManager.Instance.Timer;
            CounterText1.text = "And";
        }
        else if (GameManager.Instance.Timer > 3 && GameManager.Instance.Timer < 6)
        {
            timer = GameManager.Instance.Timer;
            CounterText1.text = "Go!";
        }
        else
        {
            CounterText1.text = null;
        }
    }
}

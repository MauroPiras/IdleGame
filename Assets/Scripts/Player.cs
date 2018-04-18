using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	[SerializeField] public Text TxtConteggio;
	private int NmbConteggio;
	// Use this for initialization
	void Start () {
		TxtConteggio.text = "Souls count: 0";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			TxtConteggio.text = "Souls count: " + ++NmbConteggio;
		}
	}
}

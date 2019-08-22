﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HT_Score : MonoBehaviour {

	public Text scoreText;
	public int ballValue;

	private int score;

	void Start () {
		score = 0;
		UpdateScore ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		score += ballValue;
		UpdateScore ();
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Bomb") {
			score -= ballValue * 2;
			UpdateScore ();
		}
	}

	void UpdateScore () {
		scoreText.text = "SCORE:\n" + score;
	}
}

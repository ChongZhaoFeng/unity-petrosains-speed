﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class bs_BrakeLight : MonoBehaviour {

	private MeshRenderer _mr;
	private bs_CarController _cc;
	// Use this for initialization
	void Start () 
	{
		_mr = GetComponent<MeshRenderer> ();
		_mr.enabled = false;
		_cc = GameObject.FindObjectOfType<bs_CarController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (_cc != null) 
		{
			if (_cc.Deccelerating || _cc.HandBrake)
				_mr.enabled = true;
			else
				_mr.enabled = false;
		}
	}
}

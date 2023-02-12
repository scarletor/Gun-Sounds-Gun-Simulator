﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Colorizer : MonoBehaviour {

	public Color TintColor;
	public bool UseInstanceWhenNotEditorMode = true;

	private Color oldColor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(oldColor != TintColor) ChangeColor(gameObject, TintColor);
		oldColor = TintColor;
	}

	void ChangeColor(GameObject effect, Color color)
	{	
		var rend = effect.GetComponentsInChildren<Renderer>();
		foreach (var r in rend) {

		}
		var light = effect.GetComponentInChildren<Light>();
		if(light!=null) light.color = color;
	}
}

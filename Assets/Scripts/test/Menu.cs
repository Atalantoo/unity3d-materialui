﻿using UnityEngine;
using System.Collections;
using System.IO;

using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{
	// VIEW

	void Start ()
	{
		GameObject canvas = CanvasBuilder
			.parent (this.transform)
			.build ();
		GameObject panel = PanelBuilder
			.parent (canvas.transform)
			.tex_path ("panel_bkg")
			.build ();
		TextBuilder
			.parent (panel.transform)
			.y (100)
			.text ("Tests")
			.fontSize (32)
			.build ();
		TextBuilder
			.parent (panel.transform)
			.y (0)
			.text ("Choose a demo")
			.build ();
		ButtonBuilder
			.parent (panel.transform)
			.y (-100)
			.text ("Quit")
			.text_color(Color.white)
			.texture("button_bkg2")
			.normalColor(Color.blue)
			.onClick (delegate {
			quit ();
		})
			.build ();
		ButtonBuilder
			.parent (panel.transform)
			.y (-200)
			.text ("Editor")
			.onClick (delegate {
			editor ();
		})
			.build ();
		ButtonBuilder
			.parent (panel.transform)
			.y (-300)
			.text ("Map")
			.build ();
		ButtonBuilder
			.parent (panel.transform)
			.y (-400)
			.text ("Score")
			.build ();
		ButtonBuilder
			.parent (panel.transform)
			.y (-500)
			.text ("News")
			.build ();

		// BUI_Modal(this,
		//		BUI_PageHeader(
		//		  	BUI_Text.text("Test").subtext("Choose a demo")
		//		),
		//		BUI_BtnGroupVertical(
		//			BUI_Button.text("Quit")
		//			BUI_Button.text("Editor")
		//			BUI_Button.text("Map")
		//		)
		//	);
	}

	// PRESENTER

	void quit ()
	{
		// TODO use Destroy(this)
		Destroy (GameObject.Find ("Menu"));
		new GameObject ("Quit").AddComponent<Quit> ();
	}

	void editor ()
	{
		// TODO use Destroy(this)
		Destroy (GameObject.Find ("Menu"));
		new GameObject ("Editor").AddComponent<Editor> ();
	}

	// TRANSITION

	// http://docs.unity3d.com/Manual/HOWTO-UIScreenTransition.html



	/*
	// https://unity3d.com/learn/tutorials/projects/stealth/screen-fader

	// Speed that the screen fades to and from black.
	public float fadeSpeed = 1.5f;
	// Whether or not the scene is still fading in.
	private bool sceneStarting = true;

	void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}


	void Update ()
	{
		// If the scene is starting...
		if(sceneStarting)
			// ... call the StartScene function.
			StartScene();
	}

	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp (guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}


	void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp (guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
	}

	void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();

		// If the texture is almost clear...
		if(guiTexture.color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;

			// The scene is no longer starting.
			sceneStarting = false;
		}
	}

	public void EndScene ()
	{
		// Make sure the texture is enabled.
		guiTexture.enabled = true;

		// Start fading towards black.
		FadeToBlack();

		// If the screen is almost black...
		if(guiTexture.color.a >= 0.95f)
			// ... reload the level.
			Application.LoadLevel(0);
	}
	*/
}

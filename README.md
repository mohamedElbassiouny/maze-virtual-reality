VR_Game_Project3

This project is focused on learning to code the scripts that bring everything to life. Skills include:

Creating new C# scripts in Unity
If then, loops, arrays, and other programming constructs
Attaching scripts to objects
Using the built-in Monobehaviour methods
Triggers and Gaze Based Interaction
Creating, moving and animating objects procedurally
Familiarization with the Unity documentation
Scripting Dynamic UI Objects
Debugging
The Unity Event System.
Managing and Reloading scenes.
Controlling particle systems.
Create an Audio Clip and playing sounds.
Waypoint Navigation System.
Profiling scenes for performance.
Viewing MY App On a Device (Android or IOS)

Screenshot of Unity app running on phone
Successful build of the app (apk file for Android and XCode project for iOS)
All the player settings are correctly modified in order to build to device
animation

I worked a total of the animation (KEY,COIN). To make the game better Possible use by animator open the animator And arrange them as you like

Motivation

create my first fully interactive multisensory VR experience!

Installation

use the script and put in unity drag and drop

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
       // transform.Rotate(0, Input.acceleration.y * 10f * Time.deltaTime, 0);
        //Input.acceleration.x * Time.deltaTime * 10f
      //  transform.Rotate(Input.acceleration.x * Time.deltaTime * 10f, 0, 0);


        //Input.acceleration.y * 10f * Time.deltaTime

       transform.Rotate(0, 0, Input.acceleration.y * 10f * Time.deltaTime);
    }
}
Google VR SDK for Unity

Enables Daydream and Cardboard app development in Unity.

Copyright (c) 2016 Google Inc. All rights reserved.

For updates, known issues, and upgrade instructions, see: https://developers.google.com/vr/unity/release-notes

For first time users, see the Get Started Guides for Android Cardboard, Android Daydream, and iOS Cardboard.

API Script FOR UNITY

API SCRIPT

Contributors

Mohamed Elbassiouny gmail apat4e@gmail.com 

Mohamed Elbassiouny linkedin  https://www.linkedin.com/in/mohamedelbassiouny/

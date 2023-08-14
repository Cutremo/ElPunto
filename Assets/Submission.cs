using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Submission
{
    public Color color;
    public AudioClip sound;
    public float volume = 1;
    public bool loopable = false; 
    public Submission(AudioClip sound, Color color, int volume, bool loopable)
    {
        this.sound = sound;
        this.color = color;
        this.volume = volume;
        this.loopable = loopable;
    }
}

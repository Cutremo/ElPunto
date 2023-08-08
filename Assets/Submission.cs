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

    public Submission(AudioClip sound, Color color, int volume)
    {
        this.sound = sound;
        this.color = color;
        this.volume = volume;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Punto : MonoBehaviour
{
    [SerializeField] Survey survey;
    [SerializeField] Image icon;
    [SerializeField] AudioSource source;

    List<Submission> seen = new();

    void Start()
    {
        ShowNext();
    }

    public void Click()
    {
        ShowNext();
    }

    void ShowNext()
    {
        var selected = PickRandom();

        ShowSubmission(selected);

        if(seen.Count == survey.Count())
            seen.Clear();
    }

    void ShowSubmission(Submission selected)
    {
        icon.color = selected.color;
        source.clip = selected.sound;
        source.volume = selected.volume;
        source.Play();
    }

    Submission PickRandom()
    {
        var remaining = survey.Where(submission => !seen.Contains(submission)).ToArray();

        var selected = remaining[Random.Range(0, remaining.Length)];
        
        seen.Add(selected);
        
        return selected;
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Survey")]
public class Survey : ScriptableObject, IEnumerable<Submission>
{
    [SerializeField] List<AudioClip> clips;
    [SerializeField] List<Submission> submissions;
    public IEnumerator<Submission> GetEnumerator()
    {
        return submissions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    void OnValidate()
    {
        foreach(var clip in clips)
        {
            if(submissions.All(x => x.sound != clip))
            {
                submissions.Add(new Submission(clip, Color.black, 1));
            }
        }

        submissions = submissions.Where(x => x.sound != null).ToList();
    }
}
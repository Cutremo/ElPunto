using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Survey")]
public class Survey : ScriptableObject, IEnumerable<Submission>
{
    [SerializeField] List<Submission> submissions;
    public IEnumerator<Submission> GetEnumerator()
    {
        return submissions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
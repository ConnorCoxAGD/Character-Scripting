using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : MonoBehaviour
{
    public List<NameID> nameIds;
    private NameID _altIDs;

    public List<DoWork> DoWorks;

    private void OnTriggerEnter(Collider other)
    {
        _altIDs = other.GetComponent<IDBehavior>().nameIDObjs;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in nameIds)
        {
            if (obj == _altIDs)
            {
                foreach (var job in DoWorks)
                {
                    job.Work();
                }
            }
        }
    }
}

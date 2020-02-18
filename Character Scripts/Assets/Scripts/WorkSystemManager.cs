using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WorkSystemManager : ScriptableObject
{
    [Serializable]
    public struct PossibleMatches
    {
        public NameId nameIdObj;
        public WorkSystem workSystemObj;
    }

    public List<PossibleMatches> workIdList;
}
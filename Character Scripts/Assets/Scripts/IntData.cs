using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute]
public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int amount)
    {
        value = amount;
    }

    public void UpdateValue(int amount)
    {
        value += amount;
    }
    
}

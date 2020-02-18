using UnityEngine;

public class MatchIdBehaviour : IdBehaviour
{
    public WorkSystemManager workSystemManagerObj;
    private NameId otherIdObj;
    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IdBehaviour>().nameIdObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in WorkSystemManagerObj.workIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workSystemObj.Work();
            }
        }
    }
}
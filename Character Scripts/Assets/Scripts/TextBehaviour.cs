using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;

    void Awake()
    {
        textObj = GetComponent<Text>();
    }

    public void UpdateText(StringListData stringListDataObj)
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }
    public void UpdateText(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }
}

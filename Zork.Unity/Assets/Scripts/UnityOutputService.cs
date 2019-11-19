using UnityEngine;
using Zork.Common;
using TMPro;
using System.Collections.Generic;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI OutputTextPrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLines = 60;

    private UnityOutputService()
    {
        mTextlines = new List<GameObject>();
    }
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        if(mTextlines.Count >= MaxTextLines)
        {
            Destroy(mTextlines[0]);
            mTextlines.RemoveAt(0);
        }
        var textLine = Instantiate(OutputTextPrefab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mTextlines.Add(textLine.gameObject);
    }

    public void Writeline(object value)
    {
        throw new System.NotImplementedException();
    }

    private List<GameObject> mTextlines;
}

using System;
using UnityEngine.UI;
using UnityEngine;
using Zork.Common;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    public InputField InputField;

    void Start()
    {
        InputField.Select();
        InputField.ActivateInputField();
    }
    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text);
    }
}


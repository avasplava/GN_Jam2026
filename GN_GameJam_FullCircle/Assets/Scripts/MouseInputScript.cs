using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInputScript : MonoBehaviour
{
    public Vector2 WorldPosition { get; private set; }
    public event Action Clicked;

    private void OnAction(InputValue _)
    {
        Clicked?.Invoke();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent<Vector2> OnMovementkeyPressed { get;  set; }

    public void Update()
    {
        GetMovementInput();
    }

    private void GetMovementInput()
    {
        OnMovementkeyPressed?.Invoke
            (new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")));
    }
}

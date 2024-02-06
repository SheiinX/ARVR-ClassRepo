using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button3d : MonoBehaviour
{
    public UnityEvent myEvent;

    private void OnMouseDrag()
    {
        myEvent.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JustUrl : MonoBehaviour
{
    public UnityEvent simpleEvent;

    private void OnMouseDrag()
    {
        simpleEvent.Invoke();
        Application.OpenURL("https://github.com/SheiinX/");
    }
}

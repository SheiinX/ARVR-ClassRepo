using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GitButton : MonoBehaviour
{
    public UnityEvent simpleEvent;

    private void OnMouseDown()
    {
        simpleEvent.Invoke();
    }


    public void ShowUrl()
    {
        Application.OpenURL("https://github.com/SheiinX/");
    }
}

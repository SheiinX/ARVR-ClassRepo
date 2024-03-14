using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceScript : MonoBehaviour
{
    [SerializeField] private GameObject board;
    private AudioSource source;
    //[SerializeField] private AudioClip clip;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (board.activeSelf)
        {
            source.Play();
        }
    }
}

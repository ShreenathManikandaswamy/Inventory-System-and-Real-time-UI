using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    public AudioSource player;

    // Use this for initialization
    void Start()
    {

        player = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        player.Play();
    }
}
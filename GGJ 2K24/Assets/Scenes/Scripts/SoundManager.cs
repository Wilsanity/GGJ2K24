using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;

    public static SoundManager instance; 

    private void Awake()
    {

        if(instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
           
        }

      

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip= s.clip;

            s.source.volume = s.volume; 
            s.source.pitch = s.pitch; 
            s.source.loop = s.loop; 
        }
    }

    private void Start()
    {
        Play("JesterIntro");
       
    }

    public void Play( string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) 
        {
            Debug.LogWarning("Sound:" + name + "not found!");
        }
        
        s.source.Play();

    }

   
}

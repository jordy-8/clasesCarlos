using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    Sound[] sounds;
    internal static AudioManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;

            foreach(Sound sound in sounds)
            {
                sound.name = sound.clip.name;

                sound.source = gameObject.AddComponent<AudioSource>();
                sound.source.clip = sound.clip;
                sound.source.playOnAwake = sound.playOnAwake;
                sound.source.loop = sound.loop;
                sound.source.volume = sound.volume;

                sound.source.pitch = sound.pitch;
            }
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            //GetComponent<AudioSource>().Play();
            //Sounds[1].Play();
            //Play("mainScreen");
        }
    }

    internal void Play(string name)
    {
        AudioSource soundTemp = Search(name).source;
        soundTemp.Play();        
        Debug.Log("sound " + name + " not found!!!")   ;
    }

    internal void Stop(string name)
    {
        AudioSource soundTemp = Search(name).source;
        soundTemp.Stop();
        Debug.Log("sound " + name + " not found!!!")   ;
    }

    internal Sound Search(string name)
    {
        foreach(Sound sound in sounds)
            {
                if(sound.clip.name == name)
                {                    
                    return sound;
                }
            }
            return null;
    }
}


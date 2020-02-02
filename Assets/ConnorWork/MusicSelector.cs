using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelector : MonoBehaviour
{
    public AudioClip[] music;
    private AudioSource source;
    int track;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        track = (int)Mathf.Round(Random.Range(0, music.Length));
        source.clip = music[track];
        source.Play();
        source.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!source.isPlaying) {
            if (track < music.Length)
                track++;
            else
                track = 0;
            source.clip = music[track];
            source.Play();
        }
    }
}

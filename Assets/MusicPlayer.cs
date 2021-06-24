using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    
    private AudioSource _audioSource;
    private GameObject[] other;
    public AudioClip[] tracklist;
    private int lastTrack;
    private bool NotFirst = false;
    private void Awake()
    {
        other = GameObject.FindGameObjectsWithTag("Music");

        foreach (GameObject oneOther in other)
        {
            if (oneOther.scene.buildIndex == -1)
            {
                NotFirst = true;
            }
        }

        if (NotFirst == true)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    private void Update()
    {
        if (_audioSource.isPlaying == false)
        {
            int nextTrack = Random.Range(0, tracklist.Length);

            if (nextTrack != lastTrack)
            {
                _audioSource.clip = tracklist[nextTrack];
                lastTrack = nextTrack;
            }

            else
            {
                while (nextTrack == lastTrack)
                {
                    nextTrack = Random.Range(0, tracklist.Length);
                }
                _audioSource.clip = tracklist[nextTrack];
                lastTrack = nextTrack;
            }
            
            _audioSource.Play();
        }
    }   

}

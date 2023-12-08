using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource radio;
    [SerializeField] private Slider Slide;
    [SerializeField] private AudioClip[] tracks;
    [SerializeField] private int numberOfTrack;
    [SerializeField] private int Len;

    private void Start()
    {
        numberOfTrack = 0;
    }

    private void Update()
    {
        ChangeTrack();
        ChangeVolume();
    }

    private void ChangeVolume ()
    {
        //radio.volume = Slide.value;
    }
    private void ChangeTrack()
    {
        Len = tracks.Length;
        if (Input.GetKeyDown(KeyCode.B) && Len - 1 > numberOfTrack)
        {
            radio.Stop();
            numberOfTrack++;
            radio.PlayOneShot(tracks[numberOfTrack]);
        }
        if (Input.GetKeyDown(KeyCode.N) && numberOfTrack != 0) {
            radio.Stop();
            numberOfTrack--;
            radio.PlayOneShot(tracks[numberOfTrack]);
        }
        if (!radio.isPlaying)
        {
            if (Len - 1 != numberOfTrack)
            {
                radio.Stop();
                numberOfTrack++;
                radio.PlayOneShot(tracks[numberOfTrack]);
            }
            else {
                radio.Stop();
                numberOfTrack = 0;
                radio.PlayOneShot(tracks[numberOfTrack]);
            }
        }
    }
}

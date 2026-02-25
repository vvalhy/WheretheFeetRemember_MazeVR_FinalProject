using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AutoAudioFader : MonoBehaviour
{
    [Header("set the fading sound")]
    public float fadeInTime = 20.0f;  // time of fade in
    public float fadeOutTime = 1.5f; // time of fade out
    public float maxVolume = 1.0f;   // max volum

    private AudioSource audioSource;
    private bool isExiting = false;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0; // initial volum
        audioSource.loop = true; // always loop
    }

    void Start()
    {
        // fade in after entering the scene
        StartCoroutine(FadeIn());
    }

    // smooth effect when changing the scene
    void OnDisable()
    {
   
    }

    // fading in
    IEnumerator FadeIn()
    {
        float timer = 0;
        audioSource.Play();
        while (timer < fadeInTime)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0, maxVolume, timer / fadeInTime);
            yield return null;
        }
        audioSource.volume = maxVolume;
    }

    // fading out
    public IEnumerator FadeOut()
    {
        float timer = 0;
        float startVol = audioSource.volume;
        while (timer < fadeOutTime)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(startVol, 0, timer / fadeOutTime);
            yield return null;
        }
        audioSource.volume = 0;
        audioSource.Stop();
    }

    // also could press Alt+F4 or just close the windows
    void OnApplicationQuit()
    {

    }
}
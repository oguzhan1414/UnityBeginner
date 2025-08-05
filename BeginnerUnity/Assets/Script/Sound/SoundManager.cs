using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance; //

    [Header("Müzikler")]
    public AudioSource[] jungleAudios;
    public AudioSource[] beachAudious;
    void Awake()
    {
        instance = this; //tekil hale getirdik
    }

    public void MusicCal(int index)
    {
        if (index < 0 || index >= jungleAudios.Length)
        {
            Debug.Log("Geçersiz Müzik index");
        }
        foreach (AudioSource source in jungleAudios)
        {
            source.Stop();
        }
        jungleAudios[index].Play();
    }

    public void BeachMusicCal(int index)
    {
        if (index < 0 || index >= beachAudious.Length)
        {
            Debug.Log("Geçersiz Müzik Seçimi");
        }
        foreach (AudioSource source in beachAudious)
        {
            source.Stop();
        }
        beachAudious[index].Play();
    }

    /*
    void Start()
    {

        audioSource.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Stop();
        }
    }
    */
}

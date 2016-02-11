using UnityEngine;

public class GameMusicManager : MonoBehaviour
{
    private static GameMusicManager instance = null;
    public static GameMusicManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        instance = this;
    }

    public float VolumeMultiplier = 1f;
    public AudioClip music;
    void Start()
    {
        GameMusic.Instance.GetComponent<AudioSource>().volume = VolumeMultiplier;
        if(GameMusic.Instance.GetComponent<AudioSource>().clip != music)
        {
			GameMusic.Instance.GetComponent<AudioSource>().clip = music;//Replaces the old audio with the new one set in the inspector.
			GameMusic.Instance.GetComponent<AudioSource>().loop = true;
            GameMusic.Instance.GetComponent<AudioSource>().Play();//Plays the audio.
        }
    }
}

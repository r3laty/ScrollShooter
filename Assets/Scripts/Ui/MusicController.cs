 using UnityEngine;
using FMODUnity;
using FMOD.Studio;
public class MusicController : MonoBehaviour
{
    public static MusicController Instance;

    [SerializeField] private EventReference bgMusic;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Found more than one Music Controller in the scene");
        }
        Instance = this;
    }
    private void Start()
    {
        MainMusic();
    }
    private void MainMusic()
    {
        PlayOneShot(bgMusic, transform.position);

        //CreateEventInstance(bgMusic);
        //if (_rb.velocity.x != 0)
        //{
        //    PLAYBACK_STATE playback;
        //    _eventInstance.getPlaybackState(out playback);
        //    if (playback.Equals(PLAYBACK_STATE.STOPPED))
        //    {
        //        _eventInstance.start();
        //    }
        //}
        //else
        //{
        //    _eventInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        //}
    }
    public void PlayOneShot(EventReference sound, Vector3 worldPos)
    {
        RuntimeManager.PlayOneShot(sound, worldPos);
    }
    public EventInstance CreateEventInstance(EventReference sound)
    {
        EventInstance instance = RuntimeManager.CreateInstance(sound);
        return instance;
    }
}

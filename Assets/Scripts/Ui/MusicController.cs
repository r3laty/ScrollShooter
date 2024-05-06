 using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private BossHp bossHp;
    [Space]
    [SerializeField] private AudioSource mainMusic;
    [SerializeField] private AudioSource phase1Music;
    [SerializeField] private AudioSource healingSound;
    private void OnEnable()
    {
        BossFightTriggerCheck.EnteredToBossArea += OnPhase1;
        Healing.Healed += OnHealing;
    }
    private void OnDisable()
    {
        BossFightTriggerCheck.EnteredToBossArea -= OnPhase1;
        Healing.Healed -= OnHealing;
    }
    private void Start()
    {
        phase1Music.Play();
        phase1Music.Pause();

        mainMusic.Play();
    }
    private void Update()
    {
        if (bossHp.BossKilled)
        {
            phase1Music.Pause();
            mainMusic.UnPause();
        }
    }
    private void OnPhase1()
    {
        mainMusic.Pause();
        phase1Music.UnPause();

        phase1Music.Play();
    }
    private void OnHealing()
    {
        healingSound.Play();            
    }
}

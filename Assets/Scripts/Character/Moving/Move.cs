using FMOD.Studio;
using FMODUnity;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [HideInInspector] public static float DirX;

    [SerializeField] private float scale = 3;
    [Space]
    [SerializeField] private float speed = 200;
    [Space]
    [SerializeField] private EventReference footstepsSound;
    [Space]
    [SerializeField] private float dashingPower;

    private EventInstance _eventInstance;
    private Rigidbody2D _rb;
    private MovementDirection _movementDirection;

    private bool _canDash;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _movementDirection = GetComponent<MovementDirection>();
    }
    private void Start()
    {
        _eventInstance = MusicController.Instance.CreateEventInstance(footstepsSound);
    }

    private void Update()
    {
        DirX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _canDash = true;
        }
    }

    private void FixedUpdate()
    {
        if (_canDash)
        {
            Vector2 dash = new Vector2(transform.localScale.x * dashingPower * Time.fixedDeltaTime, 0);
            transform.Translate(dash);
            _canDash = false;
        }
        else if(!_canDash)
        {
            Vector2 moving = new Vector2(DirX * speed * Time.fixedDeltaTime, _rb.velocity.y);
            _rb.velocity = moving;
        }

        UpdateSound();

        _movementDirection.Flip(scale);
    }
    private void UpdateSound()
    {
        if(_rb.velocity.x != 0)
        {
            PLAYBACK_STATE playback;
            _eventInstance.getPlaybackState(out playback);
            if (playback.Equals(PLAYBACK_STATE.STOPPED))
            {
                _eventInstance.start();
            }
        }
        else
        {
            _eventInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
    public void IncreeseDashPower(int multiplier)
    {
        dashingPower *= multiplier;
    }
}

using UnityEngine;

public class BurningGhoulRuns : MonoBehaviour
{    
    [SerializeField] private Transform leftLimit;
    [SerializeField] private Transform rightLimit;
    [SerializeField] private float speed;
    [SerializeField] private float scale;

    private bool _goLeft = true;
    private bool _goRight = false;

    private void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        if (_goLeft)
        {
            transform.position = Vector2.MoveTowards(transform.position, leftLimit.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, leftLimit.position) < 0.2f)
            {
                _goLeft = false;
                _goRight = true;
                Flip("right");
            }
        }
        if (_goRight)
        {
            transform.position = Vector2.MoveTowards(transform.position, rightLimit.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, rightLimit.position) < 0.2f)
            {
                _goLeft = true;
                _goRight = false;
                Flip("left");
            }
        }
    }
    private void Flip(string side)
    {
        if (side.ToLower() == "left")
        {
            transform.localScale = new Vector3(scale, scale, 0);
        }
        else if (side.ToLower() == "right")
        {
            transform.localScale = new Vector3(-scale, scale, 0);
        }
    }

}

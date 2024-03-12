using UnityEngine;

public class MovementDirection : MonoBehaviour
{
    private MakeShot _shot;

    private void Awake()
    {
        _shot = GetComponent<MakeShot>();
    }
    public void Flip(float scale)
    {
        if (Move.DirX > 0)
        {
            transform.localScale = new Vector3(scale, scale, 0);
            _shot.FacingRight = true; 
            _shot.FacingLeft = false;
        }
        else if (Move.DirX < 0)
        {
            transform.localScale = new Vector3(-scale, scale, 0);
            _shot.FacingRight = false;
            _shot.FacingLeft = true;
        }
    }
}

using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private Transform followingTarget;
    [SerializeField] [Range(0, 1)] private float parallaxStrength = 0.1f;
    [SerializeField] bool disableVerticalParallax;
    private Vector3 targetPreviousPosition;
    private void Start()
    {
        targetPreviousPosition = followingTarget.position;
    }
    void Update()
    {
        var delta  = followingTarget.position - targetPreviousPosition;
        if (disableVerticalParallax)
        {
            delta.y = 0;
        }
        targetPreviousPosition = followingTarget.position;
        transform.position += delta * parallaxStrength;
    }
}

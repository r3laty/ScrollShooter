using UnityEngine;
using Cinemachine;


public class SwitchingCameraTriggerCheck : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera mainVirtualCamera;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mainVirtualCamera.Priority = 11;
        }
    }
}

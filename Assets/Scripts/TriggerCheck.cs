using UnityEngine;
using Cinemachine;


public class TriggerCheck : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera mainVirtualCamera;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print(collision + " on trigger enter");
            mainVirtualCamera.Priority = 11;
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        print(collision + " on collision enter");
    //    }
    //}
}

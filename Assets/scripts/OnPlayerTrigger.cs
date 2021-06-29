using UnityEngine;
using UnityEngine.Events;

public class OnPlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent OnPlayerEnter = null;
    [SerializeField] private UnityEvent OnPlayerExit = null;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out var _))
        {
            OnPlayerEnter.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out var _))
        {
            OnPlayerExit.Invoke();
        }
    }
}

using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public UnityEvent playOnAwake;
    void Start()
    {
        playOnAwake?.Invoke();
    }


}

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BallImpulse : MonoBehaviour
{
    [SerializeField] private Vector2 impulseForce;
    [SerializeField] private Vector2 timeImpulse;


    public UnityEvent addImpulseEvent;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(AddImpulseCor());
    }

    private IEnumerator AddImpulseCor()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(timeImpulse.x, timeImpulse.y));
            AddRandomImpulse();
            addImpulseEvent?.Invoke();
        }
    }

    private void AddRandomImpulse()
    {
        Vector2 direction = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        rb.AddForce(direction * Random.Range(impulseForce.x,impulseForce.y),ForceMode2D.Impulse);
    }
}

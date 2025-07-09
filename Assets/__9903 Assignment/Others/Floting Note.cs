using UnityEngine;

public class FloatingNote : MonoBehaviour
{
    public float speed = 1f;
    public float height = 0.05f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + Vector3.up * Mathf.Sin(Time.time * speed) * height;
    }
}
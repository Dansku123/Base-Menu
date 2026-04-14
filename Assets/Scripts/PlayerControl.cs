using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 8f;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += input * speed * Time.deltaTime;
        transform.position = pos;
    }
}

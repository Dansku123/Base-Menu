using UnityEngine;
using Selector.cs;

public class TextRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float speed = 2f;
    public float angle = 10f;
    // Update is called once per frame
    void Update()
    {
        if (selectedColor = true)
        {
            RotateText();
        }
        else
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        float tilt = Mathf.Sin(Time.time * speed) * angle;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, tilt);
    }
}

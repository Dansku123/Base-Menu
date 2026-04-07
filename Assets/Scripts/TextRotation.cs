using UnityEngine;
using TMPro;

public class TextRotation : MonoBehaviour
{
    public float speed = 2f;
    public float angle = 10f;
    private Selector selector;
    private TMP_Text thisText;
    private Color previousColor;
    private float startTime;

    void Start()
    {
        selector = FindObjectOfType<Selector>();
        thisText = GetComponent<TMP_Text>();
        previousColor = selector.selectedColor;
        startTime = Time.time;
    }

    void Update()
    {
        // Check if selected color changed
        if (thisText.color == selector.selectedColor)
        {
            if (previousColor != selector.selectedColor)
            {
                // Reset when selection changes
                previousColor = selector.selectedColor;
                startTime = Time.time;
                gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            RotateText();
        }
        else
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void RotateText()
    {
        float tilt = Mathf.Sin((Time.time - startTime) * speed) * angle;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, tilt);
    }
}

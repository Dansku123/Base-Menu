using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f; // Duration of the fade effect in seconds

    private Image fadeObject;
    private Color originalColor;

    void Awake()
    {
        fadeObject = GetComponent<Image>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeObject = GetComponent<Image>();
        originalColor = fadeObject.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

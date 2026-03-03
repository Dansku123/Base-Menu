using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f; // Duration of the fade effect in seconds

    private Image fadeObject;
    private Color originalColor;

    private Coroutine coroutine; 

    void Awake()
    {
        fadeObject = GetComponent<Image>();
        if (fadeObject == null)
        {
            Debug.LogError("FadeControl requires an Image component on the same GameObject.");
            return;
        }
        originalColor = fadeObject.color;
    }

    private void StartFade (float targetAlpha)
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(FadeRoutine(targetAlpha));
    }
    

    private IEnumerator FadeRoutine(float targetAlpha)
    {
        if (coroutine != null)
        {
            float time = 0f;
            float startAlpha = fadeObject.color.a;

            while (time < fadeDuration)
            {
                time += Time.deltaTime;
                Color colorChanged = fadeObject.color;
                colorChanged.a = Mathf.Lerp(startAlpha, targetAlpha, time / fadeDuration);
                fadeObject.color = colorChanged;
                yield return null;
            } 

            Color finalColor = fadeObject.color;
            finalColor.a = targetAlpha;
            fadeObject.color = finalColor;
        }
    }
}

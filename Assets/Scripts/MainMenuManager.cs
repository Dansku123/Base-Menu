using UnityEngine;

public class MainMenuManager : MonoBehaviour
{

    public FadeControl fadeControl;
    void Start()
    {
        fadeControl.gameObject.SetActive(true);
        fadeControl.FadeOut();
    }

}

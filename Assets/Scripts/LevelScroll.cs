using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelScroll : MonoBehaviour
{
 public Image selectedLevel;
 public Image rightLevel;
 public Image leftLevel;
 
 public Sprite[] levelImages;
    public int currentIndex;

    void Update()
    {
        selectedLevel.sprite = levelImages[currentIndex];
        rightLevel.sprite = levelImages[(currentIndex + 1) % levelImages.Length];
        leftLevel.sprite = levelImages[(currentIndex - 1 + levelImages.Length) % levelImages.Length];

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex = (currentIndex + 1) % levelImages.Length;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex = (currentIndex - 1 + levelImages.Length) % levelImages.Length;
        }

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Selected level: " + currentIndex);
            SceneManager.LoadScene("Game" + currentIndex);
        }
    }
}

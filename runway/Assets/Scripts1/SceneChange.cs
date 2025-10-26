using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public void MovetoScene()
    {
        SceneManager.LoadScene("typing");
    }

    public void MovetoScene2()
    {
        SceneManager.LoadScene("tutorialscene");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene("typing");
        }
    }
}

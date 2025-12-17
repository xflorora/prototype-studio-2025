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
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene("typing 1");
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene("typing 1");
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 7)
        {
            SceneManager.LoadScene("typing 2");
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 9)
        {
            SceneManager.LoadScene("typing 2");
        }
    }
}

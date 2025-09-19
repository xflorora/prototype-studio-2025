using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeStartMenu : MonoBehaviour
{
    public string sceneName;
 
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

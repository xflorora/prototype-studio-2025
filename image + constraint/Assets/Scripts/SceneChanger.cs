using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    void Update()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

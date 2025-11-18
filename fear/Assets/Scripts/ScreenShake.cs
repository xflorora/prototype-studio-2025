using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour
{
    public GameObject mainCamera;
    private Vector3 camOriginPos;
    private float shakeIntensity = 1f;
    public bool isCameraShaking = false;
    public AudioSource spiderAudio;

    void Start()
    {
        camOriginPos = mainCamera.transform.position;
        spiderAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isCameraShaking = true;
            spiderAudio.Play();
        }
        if (isCameraShaking == true)
        {
            StartCoroutine(CameraShakeRoutine());
        }
    }
    
    
    IEnumerator CameraShakeRoutine()
    {
        mainCamera.transform.position = camOriginPos + (Random.insideUnitSphere * shakeIntensity);
        yield return new WaitForSeconds(0.25f);
        mainCamera.transform.position = camOriginPos;
        isCameraShaking = false;
    }
}

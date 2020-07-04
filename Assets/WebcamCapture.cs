using UnityEngine;

public class WebcamCapture : MonoBehaviour
{
    /// <summary>
    /// Material used to play with the webcam texture.
    /// </summary>
    [SerializeField]
    private Material _material = default;

    /// <summary>
    /// Texture containing the webcam capture, will be send to the shader.
    /// </summary>
    private WebCamTexture _webCamTexture;

    /// <summary>
    /// Initialize the webcam texture and start capturing.
    /// </summary>
    private void Start()
    {
        if (_webCamTexture == null)
        {
            _webCamTexture = new WebCamTexture();
        }

        _webCamTexture.requestedHeight = 512;
        _webCamTexture.requestedWidth = 512;
        _webCamTexture.Play();
    }

    /// <summary>
    /// Send texture to the shader.
    /// </summary>
    private void Update()
    {
        if (_material == null)
            return;

        _material.SetTexture("_WebcamTex", _webCamTexture);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraShader : MonoBehaviour
{
    [SerializeField]
    public Material postProcessMaterial;
    public float BlurSize = 0.1f;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        postProcessMaterial.SetFloat("_BlurSize", BlurSize);

        var temporaryTexture = RenderTexture.GetTemporary(source.width, source.height);
        Graphics.Blit(source, temporaryTexture, postProcessMaterial, 0);
        Graphics.Blit(temporaryTexture, destination, postProcessMaterial, 1);
        RenderTexture.ReleaseTemporary(temporaryTexture);

    }
}
using UnityEngine;

public class ObjectTransparency : MonoBehaviour
{
    public float fadeDistance = 7.0f; // The distance at which the objects start to fade
    public float fadeSpeed = 0.125f; // The speed at which the objects fade

    private Material[] materials; // The materials of all the objects in the scene
    private Color[] originalColors; // The original colors of all the objects in the scene
    private float[] originalAlphas; // The original alpha values of all the materials in the scene

    void Start()
    {
        // Get all the materials in the scene and store their original colors and alpha values
        Renderer[] renderers = FindObjectsOfType<Renderer>();
        materials = new Material[renderers.Length];
        originalColors = new Color[renderers.Length];
        originalAlphas = new float[renderers.Length];
        for (int i = 0; i < renderers.Length; i++)
        {
            materials[i] = renderers[i].material;
            originalColors[i] = materials[i].color;
            originalAlphas[i] = materials[i].color.a;
        }
    }

    void Update()
    {
        // Get the distance between the camera and the NavMesh agent
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        // If the distance is less than the fade distance, start fading the objects
        if (distance < fadeDistance)
        {
            // Calculate the new alpha value based on the distance
            float alpha = Mathf.Lerp(1.0f, 0.0f, (distance / fadeDistance));

            // Set the alpha value of all the materials in the scene
            for (int i = 0; i < materials.Length; i++)
            {
                Color newColor = originalColors[i];
                newColor.a = Mathf.Lerp(originalAlphas[i], 0.0f, (distance / fadeDistance));
                materials[i].color = newColor;
            }
        }
        else
        {
            // If the distance is greater than the fade distance, restore the original alpha values of all the materials
            for (int i = 0; i < materials.Length; i++)
            {
                Color newColor = originalColors[i];
                newColor.a = originalAlphas[i];
                materials[i].color = newColor;
            }
        }
    }
}

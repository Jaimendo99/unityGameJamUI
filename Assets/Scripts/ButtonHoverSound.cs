using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource soundSource;
    public AudioClip hoverSound;

    public GameObject selector;

    private void Start()
    {
        // Ensure the sound source has been assigned
        if (soundSource == null)
        {
            Debug.LogError("Sound source not assigned to ButtonSound script on " + gameObject.name);
            return;
        }

        // Ensure the hover sound has been assigned
        if (hoverSound == null)
        {
            Debug.LogError("Hover sound not assigned to ButtonSound script on " + gameObject.name);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Play the hover sound when the mouse enters the button
        soundSource.PlayOneShot(hoverSound);

        // If a selector has been assigned, move it to the button's only Y position
        if (selector != null)
        {
            selector.transform.position = new Vector3(selector.transform.position.x, transform.position.y, selector.transform.position.z);
        }
    }
}

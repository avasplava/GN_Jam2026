using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{
    public UnityEvent interacted;

    public AudioSource mouseClickAudio;

    void OnMouseDown()
    {
        Debug.Log("Clicked on object");
        mouseClickAudio.Play();
        interacted.Invoke();
    }
}

using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;

    void OnMouseDown()
    {
        Debug.Log("Clicked on object");
        interacted.Invoke();
    }
}

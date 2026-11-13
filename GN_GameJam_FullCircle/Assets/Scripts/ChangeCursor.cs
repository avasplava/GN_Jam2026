using UnityEngine;
using UnityEngine.EventSystems;
public class ChangeCursor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private CursorController.ModeOfCursor modeOfCursor;


    public void OnPointerEnter(PointerEventData eventData)
    {
        CursorController.Instance.SetToMode(modeOfCursor);
    }

    public void OnPointerExit(PointerEventData  eventData)
    {
        CursorController.Instance.SetToMode(CursorController.ModeOfCursor.Default);
    }
}
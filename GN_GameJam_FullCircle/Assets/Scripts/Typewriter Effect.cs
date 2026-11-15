using UnityEngine;
using TMPro;
using System.Collections;

public class TypewriterEffect : MonoBehaviour
{

    public TMP_Text text3D;
    public float typingSpeed = 0.05f;
    public float displayTime = 2f;
    private string fullText;
    private Coroutine typingCoroutine;

    void Awake()
    {
        if (text3D == null)
            text3D = GetComponent<TMP_Text>();

        fullText = text3D.text;
    }

    void OnEnable()
    {
        if (text3D == null)
            return;

        text3D.enabled = true;
        text3D.text = "";

        typingCoroutine = StartCoroutine(TypeAndHide());
    }

    void OnDisable()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            typingCoroutine = null;
        }
    }

    IEnumerator TypeAndHide()
    {
        foreach (char letter in fullText)
        {
            text3D.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForSeconds(displayTime);

        text3D.enabled = false;
        typingCoroutine = null;
    }
}

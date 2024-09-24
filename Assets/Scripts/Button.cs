using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler {
    bool on;
    Animator animator;

    public void OnPointerClick(PointerEventData eventData) 
    {
        Debug.Log("Click");
        on = true;
    }

    public void OnPointerDown(PointerEventData eventData) 
    {

    }

    public void OnPointerEnter(PointerEventData eventData) 
    {

    }

    public void OnPointerExit(PointerEventData eventData) 
    {

    }

    public void OnPointerUp(PointerEventData eventData) 
    {

    }

    void Update() {
        if (on) {
            animator = GetComponent<Animator>();
        }
    }
}

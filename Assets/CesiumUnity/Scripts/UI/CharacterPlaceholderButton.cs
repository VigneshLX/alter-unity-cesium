using UnityEngine;
using UnityEngine.EventSystems;

namespace Alter.CesiumUnity.UI
{
    public class CharacterPlaceholderButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] public CanvasGroup OnHoverUI;

        public void OnPointerEnter(PointerEventData eventData)
        {
            LeanTween.alphaCanvas(OnHoverUI, 1, 0.5f);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            LeanTween.alphaCanvas(OnHoverUI, 0, 0.5f);
        }
    }
}

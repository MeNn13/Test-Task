using UnityEngine;
using UnityEngine.EventSystems;

public class SkillDropdown : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject skillDownPanel;

    private bool isActive;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isActive)
        {
            skillDownPanel.SetActive(true);
            isActive = true;
        }
        else
        {
            skillDownPanel.SetActive(false);
            isActive = false;
        }
    }
}

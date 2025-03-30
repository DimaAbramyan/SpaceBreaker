using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    [SerializeField] public List<Sprite> SelectStatus; // 0 - НЕ выбран (бел), 1 - спрашивает (желт), 2 - выбран (зел)
    [SerializeField] private GameObject PanelToShow;
    public void ShowingPanel()
    {
        CheckAfterChoice();
        SaveLoadUI[] objects = FindObjectsOfType<SaveLoadUI>();

        ShowPanel[] button = FindObjectsOfType<ShowPanel>();

        Image image = GetComponent<Image>();
        if ((PanelToShow.activeSelf)&&(image!= null))
        {
            if (image.GetComponent<Save>().save.shipName != "")
            {
                SwitchImage(gameObject, 2);
            }
            else
            {
                SwitchImage(gameObject, 0);
            }
        }
        else
        {
            SwitchImage(gameObject, 1);
        }
        PanelToShow.SetActive(!PanelToShow.activeSelf);
        //Debug.Log(GetComponent<Save>().save.shipName);
        
        foreach (var obj in objects)
        {
            obj.gameObject.SetActive(false);
        }
    }
    void CheckAfterChoice ()
    {
        ShowPanel[] buttons = FindObjectsOfType<ShowPanel>();
        foreach (var button in buttons)
        {
            if (button != null)
             if (button.GetComponent<Save>().save.shipName != "")
            {
                SwitchImage(button.gameObject, 2);
            }
             else
            {
                SwitchImage(button.gameObject, 0);
            }

        }

    }
    public void SwitchImage(GameObject ToChange,  int SelectTo)
    {
       // Debug.Log(ToChange);
        if (ToChange.GetComponent<Image>().sprite != null && SelectStatus[0] != null)
        ToChange.GetComponent<Image>().sprite = SelectStatus[SelectTo];
    }
}

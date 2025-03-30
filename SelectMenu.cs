using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System.Collections;
public class SaveLoadUI : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;
    [SerializeField] private GameObject[] ships;
    public GameObject buttonPrefab;  // Префаб кнопки (сохранения)
    public Transform content;        // Контейнер для кнопок
    public Save LoadTo;              // Куда сохраняется выбранный корабль
    private string savePath;
    private string[] savesThatAlreadyExist;
    void OnEnable()
    {
        savesThatAlreadyExist = FindObjectsOfType<Save>().Select(obj => obj.save.shipName).ToArray();
        //Debug.Log(savesThatAlreadyExist[0] + " - 1 корабль");
        //Debug.Log(savesThatAlreadyExist[1] + " - 2 корабль");
        //Debug.Log(savesThatAlreadyExist[2] + " - 3 корабль");
        savePath = Application.persistentDataPath + "/Saves";
        LoadSaveFiles();
        if (LoadTo.save.shipName != "")
        {
            GameObject newButton = Instantiate(buttonPrefab, content);
            newButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = LoadTo.save.shipName;
            PrintShip(newButton, LoadTo.save);
            newButton.transform.SetAsFirstSibling();
            newButton.GetComponent<Button>().onClick.AddListener(() => CloseAndForget());
            newButton.GetComponent<Image>().color = new Color(0.5f, 0.8f, 1f);
        }
    }
    // Загрузка сохранений в Content
    public void LoadSaveFiles()
    {
        // Очистка старых кнопок
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }

        // Проверяем, есть ли папка с сохранениями
        if (!Directory.Exists(savePath))
            return;

        // Получаем список файлов сохранений
        string[] files = Directory.GetFiles(savePath, "*.json");

        foreach (string file in files)
        {
            CreateSaveButton(Path.GetFileNameWithoutExtension(file), file);
            TryToFindCreatedShip(file);
        }
    }

    // Создание самой кнопки
    void CreateSaveButton(string saveName, string filePath)
    {
        string json = File.ReadAllText(filePath);
        SaveShip Ship = JsonUtility.FromJson<SaveShip>(json);
        
        if (savesThatAlreadyExist.Contains(Ship.shipName))
            return;
        GameObject newButton = Instantiate(buttonPrefab, content);
        newButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = saveName;
        newButton.GetComponentsInChildren<TMPro.TextMeshProUGUI>()[1].text = Ship.shipDescr;
        newButton.GetComponent<Button>().onClick.AddListener(() => LoadSave(filePath));
        PrintShip(newButton, Ship);
    }

    void LoadSave(string filePath)
    {
       // Debug.Log("Загружаем файл: " + filePath);
        string json = File.ReadAllText(filePath);
        SaveShip Ship = JsonUtility.FromJson<SaveShip>(json);
        LoadTo.save = Ship;
        //Debug.Log(LoadTo.save.shipId);
        Sprite image = LoadTo.GetComponent<ShowPanel>().SelectStatus[2];
        LoadTo.GetComponent<Image>().sprite = image;
        this.gameObject.SetActive(false);
    }
    void TryToFindCreatedShip(string filePath)
    {
        
    }
    void PrintShip(GameObject newButton, SaveShip Ship)
    {
        Image ImageOfShip = newButton.GetComponentsInChildren<Image>().Skip(1).FirstOrDefault();
        GameObject CreatedShip = Instantiate<GameObject>(ships[Ship.shipId], ImageOfShip.transform);
        foreach (weapon_Saving w in Ship.Data)
        {
            GameObject weap = Instantiate<GameObject>(weapons[w.ID], ImageOfShip.transform);
            weap.transform.localPosition = w.place;
        }
        GameObject[] obj = ImageOfShip.GetComponentsInChildren<Transform>().Skip(1).Select(t => t.gameObject).ToArray();
        switch (Ship.shipId)
        {
            case 0:
                {
                    foreach (GameObject t in obj)

                        t.transform.localPosition *= 2.5f;
                    return;
                }
            case 1:
                {
                    foreach (GameObject t in obj)
                        t.transform.localPosition *= 2.5f;
                    return;
                }
            case 2:
                {
                    foreach (GameObject t in obj)
                        t.transform.localPosition *= 2.0f;
                    foreach (GameObject t in obj)
                        t.transform.localPosition = new Vector3(t.transform.localPosition.x, t.transform.localPosition.y - 50, t.transform.localPosition.z);
                    return;
                }

        }
    }
    void CloseAndForget()
    {
        LoadTo.save.shipName = "";
        this.gameObject.SetActive(false);
        LoadTo.GetComponent<Image>().color = Color.white;
    }
}
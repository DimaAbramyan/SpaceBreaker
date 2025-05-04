using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class weapon_Data:MonoBehaviour
{
    public int ID;
    public Vector3 place;
}
[System.Serializable]
public class weapon_Saving
{
    public int ID;
    public Vector3 place;
    public weapon_Saving(int id, Vector3 position)
    {
        ID = id;
        place = position;
    }
    public weapon_Saving()
    {
        ID = 0;
        place = new Vector3(0,0,0);
    }
    public int GetID()
    { return ID; }
}
[System.Serializable]
public class SaveShip
{
    public weapon_Saving[] Data;
    public int shipId;
    public string shipName;
    public string shipDescr;
    public SaveShip(weapon_Saving[] data, int shipId, string name, string descr)
    {
        this.shipId = shipId;
        Data = data;
        shipName = name;
        shipDescr = descr;
    }
}
public class SaveSystem : MonoBehaviour
{
    public static void SaveShipData(SaveShip saveData)
    {
        // Определяем путь к папке сохранений
        string directoryPath = Application.persistentDataPath + "/Saves";

        // Если папка не существует – создаём
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }


        string filePath = Path.Combine(directoryPath, $"{saveData.shipName}.json");
        if (File.Exists(filePath))
        {
            Debug.Log("Данное название занято, переименуйте корабль");
            return;
        }
        if (saveData.shipName == "")
        {
            Debug.Log("Введите название корабля");
            return;
        }

        // Сериализуем объект в JSON
        string json = JsonUtility.ToJson(saveData, true);

        // Записываем JSON в файл
        File.WriteAllText(filePath, json);

        Debug.Log($"Сохранение выполнено: {filePath}");
        SceneManager.LoadScene("SelectMenu");
    }
}
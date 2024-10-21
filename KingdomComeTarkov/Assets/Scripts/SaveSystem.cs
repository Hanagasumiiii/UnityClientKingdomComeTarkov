using UnityEngine;
using System;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static void SaveData()
    {
        // Создаем путь к файлу сохранения
        string path = Path.Combine(Application.persistentDataPath, "Save.json");

        // Контейнер для данных сохранения
        Data data = new Data();

        // Здесь обновление данных, которые нужно сохранить

        // Сохранение данных в формате Json
        File.WriteAllText(path, JsonUtility.ToJson(data));
    }


    public static void LoadData()
    {
        // Создаем путь к файлу сохранения
        string path = Path.Combine(Application.persistentDataPath, "Save.json");

        // Контейнер для данных сохранения
        Data data = new Data();

        // Проверяем, существует ли файл сохранения
        if (File.Exists(path))
        {
            // Наполняем контейнер
            data = JsonUtility.FromJson<Data>(File.ReadAllText(path));

            // Загрузка данных, которые нужно получить
        }
        else
        {
            // Логика для случая, когда отсутствует файл сохранения
        }
    }
    
}

public class Data
{
    
}

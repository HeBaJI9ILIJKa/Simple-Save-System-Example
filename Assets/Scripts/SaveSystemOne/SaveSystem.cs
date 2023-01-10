using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    private static string _path;

    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        var directory = Application.persistentDataPath + "/saves/SaveSystemOne";
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        _path = directory + "/PlayerSave.save";

        FileStream stream = new FileStream(_path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        if(File.Exists(_path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(_path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + _path);
            return null;
        }

    }

 
}

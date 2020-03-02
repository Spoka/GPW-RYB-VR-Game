using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataSystem
{
    public static void SaveHighScore (HighScore hSData)
    {
        BinaryFormatter bN_Formatter = new BinaryFormatter();
        string filePath = Application.persistentDataPath + "/highscore.data";
        FileStream stream = new FileStream(filePath, FileMode.Create);
        HighScoreData data = new HighScoreData(hSData);

        bN_Formatter.Serialize(stream, data);
        stream.Close();
    }

    public static HighScoreData LoadHighScore()
    {
        string filePath = Application.persistentDataPath + "/highscore.data";
        if (File.Exists(filePath))
        {
            BinaryFormatter bN_Formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Open);

            HighScoreData data = bN_Formatter.Deserialize(stream) as HighScoreData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("No data file found within: " + filePath);
            return null;
        }
    }
}

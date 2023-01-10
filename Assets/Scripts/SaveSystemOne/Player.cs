using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    [SerializeField] private int _level;

    [SerializeField] private string _name;

    public int Health => _health;

    public int Level => _level;

    public string Name => _name;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Player1 saved");
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        _level = data.Level;
        _health = data.Health;
        _name = data.Name;

        Vector3 position;
        position.x = data.Position[0];
        position.y = data.Position[1];
        position.z = data.Position[2];
        transform.position = position;
 
        Quaternion rotation;
        rotation.x = data.Rotation[0];
        rotation.y = data.Rotation[1];
        rotation.z = data.Rotation[2];
        rotation.w = data.Rotation[3];
        transform.rotation = rotation;

        Debug.Log("Player1 loaded");
    }

}

using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private int _health;

    [SerializeField] private int _level;

    [SerializeField] private string _name;

    public int Health => _health;

    public int Level => _level;

    public string Name => _name;


    private Storage storage;
    private GameData gameData;

    private void Start()
    {
        storage = new Storage();
    }

    public void Save()
    {
        gameData = new GameData();

        gameData.health = _health;
        gameData.level = _level;
        gameData.name = _name;
        gameData.position = transform.position;
        gameData.rotation = transform.rotation;

        storage.Save(gameData);
        Debug.Log("Player2 saved");
    }

    public void Load()
    {
        gameData = (GameData)storage.Load(new GameData());

        transform.position = gameData.position;
        transform.rotation = gameData.rotation;

        _health = gameData.health;
        _level = gameData.level;
        _name = gameData.name;

        Debug.Log("Player2 loaded");
    }
}

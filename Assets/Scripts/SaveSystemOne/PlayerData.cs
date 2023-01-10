
[System.Serializable]
public class PlayerData 
{
    private int _health;
    private int _level;
    private string _name;
    private float[] _position;
    private float[] _rotation;

    public int Health => _health;
    public int Level => _level;
    public string Name => _name;
    public float[] Position => _position;
    public float[] Rotation => _rotation;


    public PlayerData(Player player)
    {
        _level = player.Level;
        _health = player.Health;
        _name = player.name;

        _position = new float[3];
        _position[0] = player.transform.position.x;
        _position[1] = player.transform.position.y;
        _position[2] = player.transform.position.z;

        _rotation = new float[4];
        _rotation[0] = player.transform.rotation.x;
        _rotation[1] = player.transform.rotation.y;
        _rotation[2] = player.transform.rotation.z;
        _rotation[3] = player.transform.rotation.w;
    }
}

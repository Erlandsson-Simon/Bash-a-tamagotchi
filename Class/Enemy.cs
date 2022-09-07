public class Enemy
{
    string name = "";

    Vector2 position {get; set;}

    public int hp {get; set;} = 100;

    int damage {get; set;} = 10;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
                if (name != "" && name.All(char.IsLetter))
            {
                name = value; 
            }
        }
    }
}

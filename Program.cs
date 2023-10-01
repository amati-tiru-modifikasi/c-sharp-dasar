using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();
string[,] group = AssignGroup();
Console.WriteLine("School A");
// PrintGroup(group);

// we create 2D array dimension
string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length/groups];

    // start pettingZoo position
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[start++];
        }
    }
    return result;
}

void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);
        string tmp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = tmp;
    }

    foreach(string animal in pettingZoo) 
    {
        Console.WriteLine(animal);
    }
}
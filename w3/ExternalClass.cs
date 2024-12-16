class External
{
    public string color = "Blue in external class";
public void ExploreMethod(string text)
    //To define methods as a field of a class must start with public access modifier
    {
        Console.WriteLine($"This {text} is comming from Main file");
    }
}
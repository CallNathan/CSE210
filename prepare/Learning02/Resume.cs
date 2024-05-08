public class Resume{
    public string _name;
    public List<Job> _jobs;

    public void Display(){
        Console.WriteLine(_name);
        foreach (Job x in _jobs){
            Console.WriteLine(x);
        }
    }
}
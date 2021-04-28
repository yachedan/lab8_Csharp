namespace task2
{
    public interface Client
    {
        string Id{get; set;}
        string Name{get; set;}
        int Balance{get; set;}
        double GetCredit(int initial, double percent);
        void GetInfo();
        
    }
}
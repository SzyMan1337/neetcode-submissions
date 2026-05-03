public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        var fleet = new Stack<double>();
        int n = position.Length;
        var cars = new List<(int pos, int spd)>(n);      
        for (int i = 0; i < n; i++) cars.Add((position[i], speed[i]));  
        cars.Sort((a, b) => a.pos.CompareTo(b.pos));

        foreach (var car in cars)
        {
            double arrivalTime = (target - car.pos) / (double)car.spd;
            fleet.Push(arrivalTime);
        }

        int counter = 0;
        while(fleet.Count > 0)
        {
            double currentArrivalTime = fleet.Pop();
            counter++;
            while (fleet.Count != 0 && fleet.Peek() <= currentArrivalTime)
            {
                fleet.Pop();
            }

        }
        return counter;
    }
}

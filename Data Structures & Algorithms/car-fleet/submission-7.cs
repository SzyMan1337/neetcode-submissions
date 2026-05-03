public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        int n = position.Length;
        var cars = new List<(int pos, int spd)>(n);      
        for (int i = 0; i < n; i++) cars.Add((position[i], speed[i]));  
        cars.Sort((a, b) => b.pos.CompareTo(a.pos));

        double currentFleetArivalTime = -double.MaxValue;
        int counter = 0;
        foreach (var car in cars)
        {
            double arrivalTime = (target - car.pos) / (double)car.spd;
            if(currentFleetArivalTime < arrivalTime)
            {
                counter++;
                currentFleetArivalTime = arrivalTime;
            }
        }

        return counter;
    }
}

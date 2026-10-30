public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = position
            .Zip(speed, (pos, sp) => new Car(pos, sp))
            .OrderByDescending(car =>car.Position);

        double currentTime = 0;
        var fleetsCount = 0;

        foreach(var car in cars){
            double time = (double) (target - car.Position) / (double) car.Speed;

            if(time > currentTime){
                currentTime = time;
                fleetsCount++;   
            }
        }

        return fleetsCount;
    }

    struct Car
    {
        public int Position { get; private set; }
        public int Speed { get; private set; }

        public Car(int position, int speed){
            Position = position;
            Speed = speed;
        }
    }
}

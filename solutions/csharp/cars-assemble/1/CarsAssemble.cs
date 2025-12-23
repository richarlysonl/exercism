static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        //"Please implement the (static) AssemblyLine.SuccessRate() method;"
        if(speed == 10){
            return 0.77;
        }else
        if(speed == 9){
            return 0.8;
        }else
        if(speed == 5 || speed == 6 || speed == 7 || speed == 8){
            return 0.9;
        }else
        if(speed == 1 || speed == 2 || speed == 3 || speed == 4){
            return 1;
        }else{
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //"Please implement the (static) AssemblyLine.ProductionRatePerHour() method"
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //"Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method"
        return (int)Math.Floor(speed * 221 * SuccessRate(speed)) / 60;
        
    }
}

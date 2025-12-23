class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
   public int RemainingMinutesInOven(int elapsed_minutes)
    {
            return 40 - elapsed_minutes;
    }
    public int PreparationTimeInMinutes(int layers_to_prep)
    {
        return layers_to_prep * 2;
    }
    public int ElapsedTimeInMinutes(int layers_to_prep, int elapsed_minutes)
    {
        int timeAll = (layers_to_prep * 2) + elapsed_minutes;
            return timeAll;
    }
}

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake == false){
            return true;
        }else{
            return false;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if((knightIsAwake == false && archerIsAwake ==true && prisonerIsAwake == false) || (knightIsAwake == true && archerIsAwake ==false && prisonerIsAwake == false) || (knightIsAwake == false && archerIsAwake ==false && prisonerIsAwake == true)
|| (knightIsAwake == false && archerIsAwake ==true && prisonerIsAwake == true)
          || (knightIsAwake == true && archerIsAwake ==false && prisonerIsAwake == true)|| (knightIsAwake == true && archerIsAwake ==true && prisonerIsAwake == true)
          || (knightIsAwake == true && archerIsAwake ==true && prisonerIsAwake == false)){
            return true;
        }else{
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake == false && prisonerIsAwake == true){
            return true;
        }else{
            return false;
            }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent == true){
            if(archerIsAwake == false){
                return true;
            }else {return false;}
        }else if(archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == true){
            return true;
        }
        else{
            return false;
             }
    }
}

using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake){
            return false;
        }else{
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake){
            return true;
        }else{
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake && prisonerIsAwake){
            return false;
        }else{
            if(prisonerIsAwake){
                return true;
            }else{
                return false;
            }
            return true;
        }
        
            
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent){
            if(archerIsAwake){
                return false;
            }else{
                return true;
            }
        }else{
            if(knightIsAwake){
                return false;
            }
            if(archerIsAwake){
                return false;
            }
            if(prisonerIsAwake){
                return true;
            }
            return false;
        }
    }
}

<?php

class Lasagna
{
    public function expectedCookTime()
    {
            return 40;
    }

    public function remainingCookTime($elapsed_minutes)
    {
        if($elapsed_minutes < 40){
            return 40 - $elapsed_minutes;
        }
    }

    public function totalPreparationTime($layers_to_prep)
    {
        return $layers_to_prep * 2;
    }

    public function totalElapsedTime($layers_to_prep, $elapsed_minutes)
    {
        $timeAll = ($layers_to_prep * 2) + $elapsed_minutes;
            return $timeAll;
    }

    public function alarm()
    {
            return "Ding!";
    }
}

    $timer = 0;
    
    $timer = new Lasagna();
$timer->expectedCookTime;
$timer = new Lasagna();
$timer->remainingCookTime(30);
    $timer = new Lasagna();
$timer->totalPreparationTime(3);

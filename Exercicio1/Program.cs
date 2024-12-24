int result1 = Lasagna.ExpectedMinutesInOven();
Console.WriteLine(result1);

int result2 = Lasagna.RemainingMinutesInOven(30);
Console.WriteLine(result2);

int result3 = Lasagna.PreparationTimeInMinutes(2);
Console.WriteLine(result2);

int result4 = Lasagna.ElapsedTimeInMinutes(3, 20);
Console.WriteLine(result4);

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public static int ExpectedMinutesInOven()
    {
        int minutos = 40;
        return minutos;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public static int RemainingMinutesInOven(int minutos)
    {
        int temp = 40;
        return temp - minutos;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public static int PreparationTimeInMinutes(int tempo)
    {
        int totalTempoCamadas = tempo * 2;
        return totalTempoCamadas;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public static int ElapsedTimeInMinutes(int camadas, int minutos)
    {
        int tempCamadas = PreparationTimeInMinutes(camadas);
        int tempTotal = tempCamadas + minutos;
        return tempTotal;
    }
}

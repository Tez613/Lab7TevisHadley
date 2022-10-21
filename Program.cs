double Celsius = 0;
double Fahrenheit = 0;
double Kelvin = 0;
double Inches = 0;
double Feet = 0;
double yards = 0;
double Seconds = 0;
double Minutes = 0;
double Hours = 0;
(Temperature, double) CelsiusToFahrenheit()
{
    (Temperature, double) Temp = (Temperature.Fahrenheit, Fahrenheit);
    Fahrenheit = (Celsius * 1.8) + 32.00;
    Temp.Item2 = Fahrenheit;
    return Temp;
}
(Temperature, double) CelsiusToKelvin()
{
    (Temperature, double) Temp = (Temperature.Kelvin, Kelvin);
    Kelvin = Celsius + 273.15;
    Temp.Item2 = Kelvin;
    return Temp;
}
(Temperature, double) FahrenheitToCelsius()
{
    (Temperature, double) Temp = (Temperature.Celsius, Celsius);
    Celsius = (Fahrenheit - 32) * 0.56;
    Temp.Item2 = Celsius;
    return Temp;
}
(Temperature, double) FarenheitToKelvin()
{
    (Temperature, double) Temp = (Temperature.Kelvin, Kelvin);
    Kelvin = (Fahrenheit - 32.00) * 0.56 + 273.15;
    Temp.Item2 = Kelvin;
    return Temp;
}
(Temperature, double) KelvinToFahrenheit()
{
    (Temperature, double) Temp = (Temperature.Fahrenheit, Fahrenheit);
    Fahrenheit = (Kelvin - 273.15) * 1.8 + 32;
    Temp.Item2 = Fahrenheit;
    return Temp;
}
(Temperature, double) KelvinToCelsius()
{
    (Temperature, double) Temp = (Temperature.Celsius, Celsius);
    Celsius = Kelvin - 273.15;
    Temp.Item2 = Celsius;
    return Temp;
}
(Length, double) InchToFeet()
{
    (Length, double) Distance = (Length.Feet, Feet);
    Feet = Inches / 12;
    Distance.Item2 = Feet;
    return Distance;
}
(Length, double) InchsToYards()
{
    (Length, double) Distance = (Length.Yard, yards);
    yards = Inches / 36;
    Distance.Item2 = yards;
    return Distance;
}
(Length, double) FeetToInchs()
{
    (Length, double) Distance = (Length.Inch, Inches);
    Inches = Feet * 12;
    Distance.Item2 = Inches;
    return Distance;
}
(Length, double) FeetToYards()
{
    (Length, double) Distance = (Length.Yard, yards);
    yards = Feet / 3;
    Distance.Item2 = yards;
    return Distance;
}
(Length, double) YardsToFeet()
{
    (Length, double) Distance = (Length.Feet, Feet);
    Feet = yards * 3;
    Distance.Item2 = Feet;
    return Distance;
}
(Length, double) YardToInchs()
{
    (Length, double) Distance = (Length.Inch, Inches);
    Inches = Feet * 36;
    Distance.Item2 = Inches;
    return Distance;
}
(Time, double) SecondsToMinutes()
{
(Time,double) Chronology = (Time.Minutes, Minutes);
Minutes=Seconds/60;
Chronology.Item2 = Minutes;
return  Chronology;
}
(Time, double) SecondsToHours()
{
(Time,double) Chronology = (Time.Hours,Hours);
Hours=Seconds/3600;
Chronology.Item2 = Hours;
return  Chronology;
}
(Time, double) MinutesToSeconds()
{
(Time,double) Chronology = (Time.Seconds, Seconds);
Seconds = Minutes*60;
Chronology.Item2 = Seconds;
return  Chronology;
}
(Time, double) MinutesToHours()
{
(Time,double) Chronology = (Time.Hours,Hours);
Hours = Minutes/60;
Chronology.Item2 = Hours;
return  Chronology;
}
(Time, double) HoursToMinutes()
{
(Time,double) Chronology = (Time.Minutes, Minutes);
Minutes = Hours*60;
Chronology.Item2 = Minutes;
return  Chronology;
}
(Time, double) HoursToSeconds()
{
(Time,double) Chronology = (Time.Seconds, Seconds);
Seconds=Hours*3600;
Chronology.Item2 = Seconds;
return  Chronology;
}
Console.WriteLine("please pick a conversion \n ihgjhg");



enum Temperature
{
    Celsius, Fahrenheit, Kelvin
}
enum Length
{
    Inch, Feet, Yard
}
enum Time
{
    Seconds, Minutes, Hours
}
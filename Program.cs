void Celsius(){
    Console.WriteLine("How many degrees in Celsius?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Fahrenheit = (input * 1.8) + 32;
    double Kelvin = input + 273;
    Console.WriteLine($"Celsius: {input}, Fahrenheit: {Fahrenheit}, Kelvin: {Kelvin}");
}

void Fahrenheit(){
    Console.WriteLine("How many degrees in Fahrenheit?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Celsius = (input - 32)*5/9;
    double Kelvin = (input + 460)*5/9;
    Console.WriteLine($"Celsius: {Celsius}, Fahrenheit: {input}, Kelvin: {Kelvin}");
}

void Kelvin(){
    Console.WriteLine("How many degrees in Kelvin?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Celsius = input - 273;
    double Fahrenheit = (1.8 * (input - 273)) + 32;
    Console.WriteLine($"Celsius: {Celsius}, Fahrenheit: {Fahrenheit}, Kelvin: {input}");
}

void Inch(){
    Console.WriteLine("How long in Inches?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Feet = input / 12;
    double Yard = input / 36;
    Console.WriteLine($"Inches: {input}, Feet: {Feet}, Yards: {Yard}");
}

void Feet(){
    Console.WriteLine("How long in Feet?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Inch = input * 12;
    double Yard = input / 3;
    Console.WriteLine($"Inches: {Inch}, Feet: {input}, Yards: {Yard}");
}

void Yard(){
    Console.WriteLine("How long in Yards?");
    /*Stopped Here*/
    double input = Convert.ToDouble(Console.ReadLine());
    double Inch = input * 36;
    double Feet = input * 3;
    Console.WriteLine($"Inches: {Inch}, Feet: {Feet}, Yards: {input}");
}

void Seconds(){
    Console.WriteLine("How long in Seconds?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Minutes = input / 60;
    double Hours = input / 3600;
    Console.WriteLine($"Seconds: {input}, Minutes: {Minutes}, Hours: {Hours}");
}

void Minutes(){
    Console.WriteLine("How long in Minutes?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Seconds = input * 60;
    double Hours = input / 60;
    Console.WriteLine($"Seconds: {Seconds}, Minutes: {input}, Hours: {Hours}");
}

void Hours(){
    Console.WriteLine("How long in Hours?");
    double input = Convert.ToDouble(Console.ReadLine());
    double Seconds = input * 3600;
    double Minutes = input * 60;
    Console.WriteLine($"Seconds: {Seconds}, Minutes: {Minutes}, Hours: {input}");
}


Console.WriteLine("What would you like to convert between? temperature, length, or time?");
string measurement = Console.ReadLine();
if(measurement == "temperature"){
    Console.WriteLine("Would you like to convert from celsius, fahrenheit, or kelvin?");
    string unit = Console.ReadLine();
    if(unit == "celsius"){
        Celsius();
    }
    else if(unit == "fahrenheit"){
        Fahrenheit();
    }
    else if(unit == "kelvin"){
        Kelvin();
    }
    else{
        Console.WriteLine("Sorry, that is an invalid input.");
    }
}
else if(measurement == "length"){
    Console.WriteLine("Would you like to convert from inches, feet, or yards?");
    string unit = Console.ReadLine();
    if(unit == "inches"){
        Inch();
    }
    else if(unit == "feet"){
        Feet();
    }
    else if(unit == "yards"){
        Yard();
    }
    else{
        Console.WriteLine("Sorry, that is an invalid input.");
    }
}
else if(measurement == "time"){
    Console.WriteLine("Would you like to convert from seconds, minutes, or hours?");
    string unit = Console.ReadLine();
    if(unit == "seconds"){
        Seconds();
    }
    else if(unit == "minutes"){
        Minutes();
    }
    else if(unit == "hours"){
        Hours();
    }
    else{
        Console.WriteLine("Sorry, that is an invalid input.");
    }
}
else{
    Console.WriteLine("Sorry, that is an invalid input.");
}

enum temperature {Celsius, Fahrenheit, Kelvin}
enum length {Inch, Feet, Yard}
enum time {Seconds, Minutes, Hours}
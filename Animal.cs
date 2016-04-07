

// Base class
class Animal {
    // Simple properties
    private double speed = 0;
    public string species { get; set; }
    public int legs { get; set; }


    // Public method
    public void walk () {
        Console.WriteLine("Base class walk method");
        speed = speed + (0.1 * legs);
    }
}

// Derived class
class Lizard : Animal {
    // Adding additional properties to what is inherited from Animal
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
}


// Base class
class Animal {
    // Simple properties
    private double speed = 0;
    public string species { get; set; }
    public int legs { get; set; }
    // Your Animal class should include a Public string "AnimalName" that acts as a getter and a setter.
    public string AnimalName {get; set;}


    // Public method
    public void walk () {
        Console.WriteLine("Base class walk method");
        speed = speed + (0.1 * legs);
    }
}

// Create a "Species" Class that inherits from the "Animal" Class. The Species class should include a public string "SpeciesName" that acts as a getter and a setter.
class Species : Animal {
    public string SpeciesName {get; set;}


// Create three or more different classes for individual animals you want to include in your zoo. Each individual animal class should inherit from "species" and should include a public string with getter and setter for "Noise". You should also include 3-4 more getter/setters of your own choosing. Try and use at least one int (integer) type and one bool (boolean).
class Tiger : Species {
    public string Noise {get;set;}

}

class Lion : Species {
    public string Noise {get; set;}
    }

class Monkey : Species {
    public string Noise {get;set;}
    }


// Derived class
class Lizard : Animal {
    // Adding additional properties to what is inherited from Animal
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
}

Lizard larry = new Lizard();
larry.legs = 4;
larry.scaleColor = "Brown";
larry.camouflage = false;
larry.walk();
Console.WriteLine("A {0} lizard moving at {1} m/s", larry.scaleColor, larry.speed);





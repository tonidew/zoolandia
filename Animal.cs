
// Base class
class Animal {
    // Simple properties
    private double speed = 0;
    public int legs { get; set; }
    public bool fur { get; set; }
    public string sound { get; set;}


    // Public method
    public void walk () {
        Console.WriteLine("Base class walk method");
        speed = speed + (0.1 * legs);
    }
    public virtual void eat (string food) {
        _food = food;
    }
}

// FIRST GENUS  - Derived class - (bears)
class Ursus : Animal {
    public string Color { get; set; }

    public override void eat (string fish) {
        _fish = fish;
    }
} 

// Derived class of Alaskan Brown Bear - the first species
class Arctos : Ursus {
    public string Name { get; set; }
}

// Derived class of Asian Black Bear - the second species
class Thibetanus : Ursus {
    public string Name { get; set; }

}

// Derived class of Newfoundland Black Bear - the third species
class Americanus hamiltoni : Ursus {
    public string Name { get; set; }

} 

// Derived class of American Black Bear - the fourth species
class Americanus : Ursus {
    public string Name { get; set; }

}

// Derived class of Polar Bear - the fifth species
class Maritimus : Ursus {
    public string Name { get; set; }
}

// SECOND GENUS - Derived class - (frogs)
class Rana : Animal {
    public string Color { get; set; }
}

// Derived class of  Northern Red-Legged Frog - first species of frog
class Aurora : Rana {
    public string Name { get; set; }
}

// Derived class of Foothill Yellow Legged Frog - second species of frog
class Boylii : Rana {
    public string Name {get; set;} 
}

// Derived class of Cascades Frog - third species of frog
class Cascadae : Rana {
    public string Name { get; set; }
}

// Derived class of Columbia Spotted Frog - fourth species of frog
class Luteiventris : Rana {
    public string Name { get; set; }
}

// Derived class of Common Frog - fifth species of frog
class Temporaria : Rana {
    public string Name { get; set; }
}

// THIRD GENUS - Derived class - (eagles)
class Haliaeetus : Animal {
    public string wingSpan { get; set; }

}

// Derived class of American Bald Eagle - first species of eagle
class Leucocephalus : Haliaeetus {
    public string Name { get; set; }

}

// Derived class of Sanford's Sea Eagle - second species of eagle
class Sanfordi : Haliaeetus {
    public string Name { get; set; }

}

// Derived class of African Fish Eagle - third species of eagle
class Vocifer : Haliaeetus {
    public string Name { get; set; }

}

// Derived class of Steller's Sea Eagle  - fourth species of eagle
class Pelagicus : Haliaeetus {
    public string Name { get; set; }

}

// Derived class of White-tailed Eagle - fifth species of eagle
class Albicilla : Haliaeetus {
    public string Name { get; set; }

}
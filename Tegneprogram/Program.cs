using System.Linq;
using Tegneprogram;

// Skriv dit program her.
// God fornøjelse


// Firkanter
Firkant BagGrundsFirkant = new Firkant("black");
Firkant[] firkantArray = { BagGrundsFirkant };
BagGrundsFirkant.X = 200; 
BagGrundsFirkant.Y = 100;
BagGrundsFirkant.Bredde = 350; 
BagGrundsFirkant.Hojde = 200;

// Cirkler
Cirkel[] cirkelArray = new Cirkel[5];
string[] cirkelFarver = { "blue", "black", "red", "yellow", "green" };
int diameter = 100; 
int placeringX = 145; 
int placeringY = 175; 

// Instantierer 5 cirkler
for(int i = 0; i< cirkelFarver.Length; i++)
{
    placeringX = placeringX + 115; 
    if(i == 3)
    {
        placeringX = 315; // var 335
        placeringY = placeringY + 50;
    }
    
    cirkelArray[i] = new Cirkel(cirkelFarver[i]);
    cirkelArray[i].Diameter = diameter;
    cirkelArray[i].X = placeringX;
    cirkelArray[i].Y = placeringY;
}

// Tegn det færdige logo
Tegning OlympicLogo = new Tegning();
  OlympicLogo.Tegn(firkantArray, cirkelArray);
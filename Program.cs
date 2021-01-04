using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alfie's Weird App";
            while (true) {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"          _  __ _      _       _______ _     _             ");
                Console.WriteLine(@"    /\   | |/ _(_)    ( )     |__   __| |   (_)            ");
                Console.WriteLine(@"   /  \  | | |_ _  ___|/ ___     | |  | |__  _ _ __   __ _ ");
                Console.WriteLine(@"  / /\ \ | |  _| |/ _ \ / __|    | |  | '_ \| | '_ \ / _` |");
                Console.WriteLine(@" / ____ \| | | | |  __/ \__ \    | |  | | | | | | | | (_| |");
                Console.WriteLine(@"/_/    \_\_|_| |_|\___| |___/    |_|  |_| |_|_|_| |_|\__, |");
                Console.WriteLine(@"                                                      __/ |");
                Console.WriteLine(@"                                                     |___/ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Main Menu");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Introduction Generator");
                Console.WriteLine("[2] Basic Calculator");
                Console.WriteLine("[3] Formula Generator");
                Console.WriteLine("[4] Converters");
                Console.WriteLine("");
                Console.WriteLine("");
                char choice = Console.ReadKey().KeyChar;
                
                {
                    switch (choice)
                    {
                        case '0':
                            Environment.Exit(0);

                            break;


                        default:
                            Console.Clear();
                            Console.WriteLine("Still Working On That One \nPress Any Key To Go Back");
                            Console.ReadKey();
                            break;

                        case '1':
                            Console.Clear();
                            Console.Write("What's Your Name? ");
                            string name = Console.ReadLine();
                            Console.Write("How Old Are You? ");
                            string Age = Console.ReadLine();
                            Console.Write("What Is Your Favourite Thing? ");
                            string Object = Console.ReadLine();
                            Console.Write("What Is Your Favourite Colour? ");
                            string Colour = Console.ReadLine();
                            Console.Write("Give An Adjective: ");
                            string Adjective = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Hi my name is " + name + " and I am " + Age + " years old. I like the colour " + Colour + ", \nMy favourite things are " + Adjective + " " + Object + "s ");
                            Console.ReadKey();
                            Console.Clear();

                            break;


                        case '2':

                            Console.Clear();
                            Console.Write("Basic Calculator, \nPlease Enter A Number: ");
                            double num1 = 0;
                            try
                            {
                                num1 = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception z)//looks for errors
                            {
                                Console.WriteLine(z + "Is Not a Number");
                            }
                            Console.Clear();

                            Console.WriteLine("Would you like to \n[1]Divide This Number By Another Number\n[2]Multiply This Number \n[3]Add This Number \n[4]Subtract This Number");
                            char calcchoice = Console.ReadKey().KeyChar;
                            Console.Clear();
                            Console.Write("Please Enter Another Number: ");
                            double sum1 = 0;
                            try
                            {
                                sum1 = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception x)//looks for errors
                            {
                                Console.WriteLine(x + "Is Not a Number");
                            }


                            switch (calcchoice) //switch statement with calcchoice being variable name
                            {
                                case '1':
                                    Console.Clear();
                                    double total1 = num1 / sum1;
                                    Console.WriteLine($"{num1} ÷ {sum1} = {total1} \nPress Any Button To Go Back");
                                    Console.ReadKey();
                                    Console.Clear();

                                    break;
                                case '2':
                                    Console.Clear();
                                    double total2 = num1 * sum1;
                                    Console.WriteLine($"{num1} × {sum1} = {total2} \nPress Any Button To Go Back");
                                    Console.ReadKey();
                                    Console.Clear(); ;
                                    
                                    break;
                                case '3':
                                    Console.Clear();
                                    double total3 = num1 + sum1;
                                    Console.WriteLine($"{num1} + {sum1} = {total3} \nPress Any Button To Go Back");
                                    Console.ReadKey();
                                    Console.Clear(); ;
                                    
                                    break;
                                case '4':
                                    Console.Clear();
                                    double total4 = num1 - sum1;
                                    Console.WriteLine($"{num1} - {sum1} = {total4} \nPress Any Button To Go Back");
                                    Console.ReadKey();
                                    Console.Clear(); ;

                                    break;
                                default:
                                    Console.WriteLine("Not valid");
                                    break;
                            }
                            break;

                        case '3':
                            Console.Clear();
                            Console.WriteLine("Welcome To The Formula Calculator Please Pick Something To Solve:");
                            Console.WriteLine("[1] Circle");
                            Console.WriteLine("[2] Square/Rectangle");
                            Console.WriteLine("[3] Triangle");
                            Console.WriteLine("[4] Arcs & Sectors");
                            Console.WriteLine("[5] Speed, Distance & Time");
                            Console.WriteLine("[6] ");
                            Console.WriteLine("[7] ");
                            Console.WriteLine("[8] ");
                            Console.WriteLine("[9] ");
                            char formulachoice1 = Console.ReadKey().KeyChar;
                            switch (formulachoice1)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Would You Like To:");
                                    Console.WriteLine("[1] Calculate The Area");
                                    Console.WriteLine("[2] Calculate The Circumference");
                                    Console.WriteLine("[3] Calculate The Radius");
                                    Console.WriteLine("[4] Calculate The Diameter");
                                    char circlechoice = Console.ReadKey().KeyChar;
                                    switch (circlechoice) //nested switch statement
                                    {
                                        case '1':
                                            Console.Clear();
                                            Console.Write("What Is The Circles Radius? (Without Units): ");
                                            double CRadiusArea = 0;
                                            try
                                            {
                                                CRadiusArea = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.WriteLine("AreaCircle = Pi × r²");
                                            Double AreaTotal = Math.PI * (CRadiusArea * CRadiusArea);
                                            Double RoundedAreaCirc = Math.Round(AreaTotal,2);
                                            Console.WriteLine("AreaCircle = Pi × " + CRadiusArea + "² ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("AreaCircle =  " + RoundedAreaCirc);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press Any Key To Go Back");
                                            Console.ReadKey();

                                            break;
                                        case '2':
                                            Console.Clear();
                                            Console.Write("What Is The Circles Diameter? (Without Units): ");
                                            double CDiamCircum = 0;
                                            try
                                            {
                                                CDiamCircum = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Circumference = Pi × d");
                                            Double CircumTotal =  Math.PI * CDiamCircum;
                                            Double RoundedCircum = Math.Round(CircumTotal, 2);
                                            Console.WriteLine("Circumference = Pi × " + CDiamCircum);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" = " + RoundedCircum);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press Any Key To Go Back");
                                            Console.ReadKey();
                                            
                                            break;
                                        case '3':
                                            Console.Clear();
                                            Console.Write("What Is The Circles Area? (Without Units): ");
                                            double CAreaRadius = 0;
                                            try
                                            {
                                                CAreaRadius = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Radius = Sqr Root of (Area ÷ Pi)");
                                            Double RadiusTotal1 = CAreaRadius / Math.PI;
                                            Double RadiusTotal2 = Math.Sqrt(RadiusTotal1);
                                            Double RoundedRadius = Math.Round(RadiusTotal2, 2);
                                            Console.WriteLine("Radius = Sqr Root Of (" + CAreaRadius + " ÷ Pi) ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Radius = " + RoundedRadius);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press Any Key To Go Back");
                                            Console.ReadKey();
                                            break;
                                        case '4':
                                            Console.Clear();
                                            Console.Write("What Is The Circles Area? (Without Units): ");
                                            double CAreaDiam = 0;
                                            try
                                            {
                                                CAreaDiam = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Diameter = (Sqr Root of (Area ÷ Pi)) ÷ 2");
                                            Double DiamTotal1 = CAreaDiam / Math.PI;
                                            Double DiamTotal2 = Math.Sqrt(DiamTotal1);
                                            Double DiamTotal3 = DiamTotal2 * 2;
                                            Double RoundedDiam = Math.Round(DiamTotal3, 2);
                                            Console.WriteLine("Diameter = (Sqr Root Of (" + CAreaDiam + " ÷ Pi)) ÷ 2 ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Diameter = " + RoundedDiam);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press Any Key To Go Back");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.WriteLine("Not valid");
    break;
                                    }
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Would You Like To:");
                                    Console.WriteLine("[1] Calculate The Perimeter");
                                    Console.WriteLine("[2] Calculate The Area");
                                    char squarechoice = Console.ReadKey().KeyChar;
                                    Console.Clear();
                                            Console.WriteLine("Is It A:");
                                            Console.WriteLine("[1] Square");
                                            Console.WriteLine("[2] Rectangle");
                                            char squarerectperimeter = Console.ReadKey().KeyChar;
                                            Console.Clear();
                                            Console.Write("What's The Length of The Square/Rectangle? (No Units): ");
                                            double squarelength = 0;
                                            try
                                            {
                                                squarelength = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                    switch (squarechoice)
                                    {
                                        case '1':
                                            
                                            switch (squarerectperimeter)
                                            {
                                                case '1':
                                                    Console.Clear();
                                                    double squareperimeter = squarelength * 4;
                                                    double roundsquareperimeter = Math.Round(squareperimeter, 2);
                                                    Console.WriteLine("SquarePerimeter = Length × 4");
                                                    Console.WriteLine($"SquarePerimeter = {squarelength} × 4");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"SquarePerimeter = {roundsquareperimeter}");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\nPress Any Key To Close");
                                                    Console.ReadKey();
                                                    break;
                                                case '2':
                                                    Console.Clear();
                                                    Console.Write("What's The Width Of The Rectangle? (No Units): ");
                                                    double rectwidth = 0;
                                                    try
                                                    {
                                                        rectwidth = Convert.ToDouble(Console.ReadLine());
                                                    }
                                                    catch (Exception error1)//checks for errors
                                                    {
                                                        Console.WriteLine(error1 + "Is Not a Number");
                                                    }
                                                    Console.Clear();
                                                    double rectperimeter = (squarelength * 2) + (rectwidth * 2);
                                                    double roundrectperimeter = Math.Round(rectperimeter, 2);
                                                    Console.WriteLine("RectanglePerimeter = (Length × 2) + (Width × 2)");
                                                    Console.WriteLine($"RectanglePerimeter = ({squarelength} × 2) + ({rectwidth} × 2)");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"RectanglePerimeter = {roundrectperimeter}");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\nPress Any Key To Close");
                                                    Console.ReadKey();
                                                    break;
                                                default:
                                                    Console.WriteLine("Not Valid");
                                                    break;
                                            }
                                            break;
                                        case '2':
                                            switch (squarerectperimeter)
                                            {
                                                case '1':
                                                    Console.Clear();
                                                    double squarearea = squarelength * squarelength;
                                                    double roundsquarearea = Math.Round(squarearea, 2);
                                                    Console.WriteLine("SquareArea = Length × Length");
                                                    Console.WriteLine($"SquareArea = {squarelength} × {squarelength}");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"SquareArea = {roundsquarearea}");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\nPress Any Key To Close");
                                                    Console.ReadKey();
                                                    break;
                                                case '2':
                                                    Console.Clear();
                                                    Console.Write("What's The Width Of The Rectangle? (No Units): ");
                                                    double rectwidtharea = 0;
                                                    try
                                                    {
                                                        rectwidtharea = Convert.ToDouble(Console.ReadLine());
                                                    }
                                                    catch (Exception error1)//checks for errors
                                                    {
                                                        Console.WriteLine(error1 + "Is Not a Number");
                                                    }
                                                    Console.Clear();
                                                    double rectarea = squarelength * rectwidtharea;
                                                    double roundrectarea = Math.Round(rectarea, 2);
                                                    Console.WriteLine("RectangleArea = Length × Width");
                                                    Console.WriteLine($"RectangleArea = {squarelength} × {rectwidtharea}");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"RectangleArea = {roundrectarea}");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\nPress Any Key To Close");
                                                    Console.ReadKey();
                                                    break;
                                                default:
                                                    Console.WriteLine("Not valid");
                                                    break;
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Not Valid");
                                            break;
                                    }
                                    break;
                                case '3':
                                    Console.Clear();
                                    Console.WriteLine("Would You Like To Calculate The:");
                                    Console.WriteLine("[1] Perimeter");
                                    Console.WriteLine("[2] Area");
                                    Console.WriteLine("[3] Hypotenuse");
                                    char trianglechoice = Console.ReadKey().KeyChar;
                                    switch (trianglechoice)
                                    {
                                        case '1':
                                            Console.Clear();
                                            Console.Write("What Is The Length Of Side 'a'? (Side): ");
                                            double trianglea = 0;
                                            try
                                            {
                                                trianglea = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Write("What Is The Length Of Side 'b'? (Base): ");
                                            double triangleb = 0;
                                            try
                                            {
                                                triangleb = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Write("What Is The Length Of Side 'c'? (Side): ");
                                            double trianglec = 0;
                                            try
                                            {
                                                trianglec = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            double triperimeter = trianglea + triangleb + trianglec;
                                            double roundtriperimeter = Math.Round(triperimeter, 2);
                                            Console.WriteLine("TrianglePerimeter = Side A + Side B + Side C");
                                            Console.WriteLine($"TrianglePerimeter = {trianglea} + {triangleb} + {trianglec}");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"TrianglePerimeter = {roundtriperimeter}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press Any Key To Close");
                                            Console.ReadKey();
                                            break;
                                        case '2':
                                            Console.Clear();
                                            Console.Write("What is The Triangles Height? ");
                                            double triangleheight = 0;
                                            try
                                            {
                                                triangleheight = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.Write("What Is The Length Of The Base? ");
                                            double trianglebase = 0;
                                            try
                                            {
                                                trianglebase = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            double triarea = (trianglebase * triangleheight) / 2;
                                            double roundtriarea = Math.Round(triarea, 2);
                                            Console.Clear();
                                            Console.WriteLine("TriangleArea = (Base × Height) ÷ 2");
                                            Console.WriteLine($"TriangleArea = {trianglebase} × {triangleheight}");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"TriangleArea = {roundtriarea}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadKey();
                                            break;
                                        case '3':
                                            Console.Clear();
                                            Console.Write("What is The Triangles Height? (a): ");
                                            double pythagorasheight = 0;
                                            try
                                            {
                                                pythagorasheight = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            Console.Clear();
                                            Console.Write("What Is The Length Of The Base? (b): ");
                                            double pythagorasbase = 0;
                                            try
                                            {
                                                pythagorasbase = Convert.ToDouble(Console.ReadLine());
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number");
                                            }
                                            double pythagorastotal1 = pythagorasheight * pythagorasheight;
                                            double pythagorastotal2 = pythagorasbase * pythagorasbase;
                                            double pythagorastotal3 = pythagorastotal1 + pythagorastotal2;
                                            double pythagorastotal4 = Math.Sqrt(pythagorastotal3);
                                            double roundpythagorastotal = Math.Round(pythagorastotal4, 2);
                                            Console.WriteLine("Hypotenuse = sqr root of (a² + b²)");
                                            Console.WriteLine($"Hypotenuse = sqr root of ({pythagorasheight}² + {pythagorasbase}²) ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"Hypotenuse = {roundpythagorastotal}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nPress Any Key To Exit...");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.WriteLine("Not Valid");
                                            break;
                                    }
                                    break;
                                case '4':
                                    Console.Clear();
                                    Console.WriteLine("What Would You Like To Calculate?");
                                    Console.WriteLine("[1] Arc Length");
                                    Console.WriteLine("[2] Sector Area");
                                    char arcsector = Console.ReadKey().KeyChar;
                                    Console.Clear();
                                    Console.WriteLine("What's The Arc/Sector's Angle? ");
                                    double arcsectordegrees = 0; //sets inputted number as a variable
                                    try
                                    {
                                        arcsectordegrees = Convert.ToDouble(Console.ReadLine());
                                    }
                                    catch (Exception error1)//checks for errors
                                    {
                                        Console.WriteLine(error1 + "Is Not a Number");
                                    }
                                    switch (arcsector)
                                    {
                                        case '1':
                                            Console.Clear();
                                            Console.WriteLine("Please Enter The Arcs Diameter (Use The Diameter Calculator If You Have Any Issues): ");
                                            double arcdiameter = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (arcdiameter) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            Console.Clear();
                                            double arclength = (arcsectordegrees / 360) * Math.PI * arcdiameter;
                                            double roundarclength = Math.Round(arclength, 2);
                                            Console.WriteLine("ArcLength = (Angle ÷ 360) × Pi × Diameter");
                                            Console.WriteLine($"ArcLength = ({arcsectordegrees} ÷ 360) × Pi × {arcdiameter}");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"ArcLength = {roundarclength}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nPress Any Key To Exit...");
                                            Console.ReadKey();
                                            break;
                                        case '2':
                                            Console.Clear();
                                            Console.WriteLine("Please Enter The Sectors Radius (Use The Diameter Calculator If You Have Any Issues): ");
                                            double sectorradius = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (sectorradius) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            Console.Clear();
                                            double sectorarea = (arcsectordegrees / 360) * Math.PI * (sectorradius * sectorradius);
                                            double roundsectorarea = Math.Round(sectorarea, 2);
                                            Console.WriteLine("SectorArea = (Angle ÷ 360) × Pi × Radius²");
                                            Console.WriteLine($"SectorArea = ({arcsectordegrees} ÷ 360) × Pi × {sectorradius}²");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"SectorArea = {roundsectorarea}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nPress Any Key To Exit...");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.WriteLine("Not Valid");
                                            break;
                                    }

                                    break;
                                case '5':
                                    Console.Clear();
                                    Console.WriteLine("Would You Like To Calculate:");
                                    Console.WriteLine("[1] Speed");
                                    Console.WriteLine("[2] Distance");
                                    Console.WriteLine("[3] Time");
                                    char sdt = Console.ReadKey().KeyChar;
                                    switch (sdt)
                                    {
                                        case '1':
                                            Console.Clear();
                                            Console.Write("How Far Did The Object Travel? ");
                                            double distanceforspeed = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (distanceforspeed) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            Console.Write("How Long Did The Object Take To Travel? ");
                                            double timeforspeed = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (timeforspeed) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            double totalspeed = distanceforspeed / timeforspeed;
                                            double roundtotalspeed = Math.Round(totalspeed, 2);
                                            Console.Clear();
                                            Console.WriteLine("Speed = Distance ÷ Time");
                                            Console.WriteLine($"Speed = {distanceforspeed} ÷ {timeforspeed}");
                                            Console.WriteLine($"Speed = {roundtotalspeed}");
                                            Console.ReadKey();
                                            break;
                                        case '2':
                                            Console.Clear();
                                            Console.Write("How Fast Was The Object Travelling? ");
                                            double speedfordistance = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (speedfordistance) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            Console.Write("How Long Did The Object Take To Travel? ");
                                            double timefordistance = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (timefordistance) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            double totaldistance = speedfordistance * timefordistance;
                                            double roundtotaldistance = Math.Round(totaldistance, 2);
                                            Console.Clear();
                                            Console.WriteLine("Distance = Speed × Time");
                                            Console.WriteLine($"Distance = {speedfordistance} × {timefordistance}");
                                            Console.WriteLine($"Distance = {roundtotaldistance}");
                                            Console.ReadKey();
                                            break;
                                        case '3':
                                            Console.Clear();
                                            Console.Write("How Far Did The Object Travel? ");
                                            double distancefortime = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (distancefortime) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            Console.Write("How Fast Was The Object Travelling? ");
                                            double speedfortime = 0; //sets inputted number as a variable with "(variable)" being the variable name
                                            try
                                            {
                                                (speedfortime) = Convert.ToDouble(Console.ReadLine()); //"(variable)" being the variable name
                                            }
                                            catch (Exception error1)//checks for errors
                                            {
                                                Console.WriteLine(error1 + "Is Not a Number"); //tells the user that the given error is not a number
                                            }
                                            double timetotal = distancefortime / speedfortime;
                                            double roundtimetotal = Math.Round(timetotal, 2);
                                            Console.Clear();
                                            Console.WriteLine("Time = Distance ÷ Speed");
                                            Console.WriteLine($"Time = {distancefortime} ÷ {speedfortime}");
                                            Console.WriteLine($"Time = {roundtimetotal}");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.WriteLine("Not Valid");
                                            break;
                                    }
                                        
                                        Console.ReadKey();
                                    break;
                                case '6':
                                    break;
                                case '7':
                                    break;
                                case '8':
                                    break;
                                case '9':
                                    break;
                                default:
                                    Console.WriteLine("Not valid");
                                    break;
                            }
                                    break;

                        case '4':
                            Console.Clear();
                            Console.WriteLine("nice");
                            Console.ReadKey();
                            break;
                    }

                }

            }//end of while true loop

                            
        }


    }
}
    
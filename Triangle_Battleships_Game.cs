using System;

namespace 2.GroupHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            bool restart = false;
            double A_x = 0;
            double A_y = 0;
            double B_x = 0;
            double B_y = 0;
            double C_x = 0;
            double C_y = 0;
            string A_xControl = "";
            string A_yControl = "";
            string B_xControl = "";
            string B_yControl = "";
            string C_xControl = "";
            string C_yControl = "";
            double A_Length = 0;
            double B_Length = 0;
            double C_Length = 0;
            double A_angle = 0;
            double B_angle = 0;
            double C_angle = 0;
            double Area = 0;
            double Area1 = 0;
            double Area2 = 0;
            double Area3 = 0;
            double FirstPlacePoint = 0;
            double SecondPlacePoint = 0;
            double ThirdPlacePoint = 0;
            double Tempscore = 0;
            string FirstPlaceName = "";
            string SecondPlaceName = "";
            string ThirdPlaceName = "";


            Console.WriteLine("  TRIANGLE BATTLESHIP\n");
            while (true)
            {
                Console.WriteLine("1-Entering ship location\n");
                Console.WriteLine("2-Listing the properties of the ship\n");
                Console.WriteLine("3-Shooting at the ship\n");
                Console.WriteLine("4-High score table\n");
                Console.WriteLine("5-Exit\n");
                string Choice = Console.ReadLine();
                if (Choice != "1" || Choice != "2" || Choice != "3" || Choice != "4" || Choice != "5")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                }

                if (Choice == "1")
                {

                    Console.Clear();
                    bool control = true;
                    Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                    while (control)
                    {
                        Console.WriteLine("Enter the x coordinate of the A vertice ");
                        A_xControl = Console.ReadLine();
                        while (!(double.TryParse(A_xControl, out A_x)) || A_x > 30 || A_x < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the x coordinate of the A vertice");
                            A_xControl = Console.ReadLine();

                        }

                        Console.WriteLine("Enter the y coordinate of the A vertice");
                        A_yControl = Console.ReadLine();
                        while (!(double.TryParse(A_yControl, out A_y)) || A_y > 12 || A_y < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the y coordinate of the A vertice");
                            A_yControl = Console.ReadLine();

                        }
                        Console.WriteLine("Enter the x coordinate of the B vertice");
                        B_xControl = Console.ReadLine();
                        while (!(double.TryParse(B_xControl, out B_x)) || B_x > 30 || B_x < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the x coordinate of the B vertice");
                            B_xControl = Console.ReadLine();

                        }
                        Console.WriteLine("Enter the y coordinate of the B vertice");
                        B_yControl = Console.ReadLine();
                        while (!(double.TryParse(B_yControl, out B_y)) || B_y > 12 || B_y < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the y coordinate of the B vertice");
                            B_yControl = Console.ReadLine();

                        }
                        Console.WriteLine("Enter the x coordinate of the C vertice");
                        C_xControl = Console.ReadLine();
                        while (!(double.TryParse(C_xControl, out C_x)) || C_x > 30 || C_x < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the x coordinate of the C vertice");
                            C_xControl = Console.ReadLine();

                        }
                        Console.WriteLine("Enter the y coordinate of the C vertice");
                        C_yControl = Console.ReadLine();
                        while (!(double.TryParse(C_yControl, out C_y)) || C_y > 12 || C_y < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The map has 30x12 measurements (x<=30 & y<=12)\n");
                            Console.WriteLine("\nWrong Input try again\n");
                            Console.WriteLine("Enter the y coordinate of the C vertice");
                            C_yControl = Console.ReadLine();

                        }

                        A_Length = Math.Sqrt((Math.Pow((B_x - C_x), 2) + Math.Pow((B_y - C_y), 2)));
                        B_Length = Math.Sqrt((Math.Pow((A_x - C_x), 2) + Math.Pow((A_y - C_y), 2)));
                        C_Length = Math.Sqrt((Math.Pow((B_x - A_x), 2) + Math.Pow((B_y - A_y), 2)));
                        A_angle = (180 / Math.PI) * Math.Acos((C_Length * C_Length + B_Length * B_Length - A_Length * A_Length) / (2 * B_Length * C_Length));
                        B_angle = (180 / Math.PI) * Math.Acos((C_Length * C_Length + A_Length * A_Length - B_Length * B_Length) / (2 * A_Length * C_Length));
                        C_angle = (180 / Math.PI) * Math.Acos((A_Length * A_Length + B_Length * B_Length - C_Length * C_Length) / (2 * B_Length * A_Length));
                        Area = (Math.Sin(A_angle * Math.PI / 180) * B_Length * C_Length) / 2;
                        if (Area != 0 && ((A_x != B_x) || (A_y != B_y)) && ((A_x != C_x) || (A_y != C_y))
                            && ((C_x != B_x) || (C_y != B_y)))
                        {

                            control = false;
                            restart = true;
                            Console.Clear();
                        Console.WriteLine("Coordinates Saved\n");


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("These points can't form a triangle!\n");
                            control = true;
                        }
                    }
                }
                if (Choice == "2" && restart == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the coordinates of the ship first.\n");
                }

                else if (Choice == "2" && Area != 0 && restart)

                {
                    Console.Clear();
                    Console.WriteLine("SHIP INFO:\n");
                    Console.WriteLine("A length of the ship is: " + String.Format("{0:0.0}", A_Length));
                    Console.WriteLine("B length of the ship is: " + String.Format("{0:0.0}", B_Length));
                    Console.WriteLine("C length of the ship is: " + String.Format("{0:0.0}", C_Length));
                    Console.WriteLine("The perimeter of the ship is: " + String.Format("{0:0.0}", A_Length + B_Length + C_Length));
                    Console.WriteLine("A angle of the ship is: " + String.Format("{0:0.0}", A_angle));
                    Console.WriteLine("B angle of the ship is: " + String.Format("{0:0.0}", B_angle));
                    Console.WriteLine("C angle of the ship is: " + String.Format("{0:0.0}", C_angle));
                    Console.WriteLine("Area of the ship is: " + String.Format("{0:0.0}", Area));
                    double A_Med_x = (B_x + C_x) / 2;
                    double A_Med_y = (B_y + C_y) / 2;
                    double B_Med_x = (A_x + C_x) / 2;
                    double B_Med_y = (A_y + C_y) / 2;
                    double C_Med_x = (B_x + A_x) / 2;
                    double C_Med_y = (B_y + A_y) / 2;
                    Console.WriteLine("Median coordinates of point A: (" + String.Format("{0:0.0}", A_Med_x) + " " + String.Format("{0:0.0}", A_Med_y) + ")");
                    Console.WriteLine("Median coordinates of point B: (" + String.Format("{0:0.0}", B_Med_x) + " " + String.Format("{0:0.0}", B_Med_y) + ")");
                    Console.WriteLine("Median coordinates of point C: (" + String.Format("{0:0.0}", C_Med_x) + " " + String.Format("{0:0.0}", C_Med_y) + ")");
                    double Centroid_x = (A_x + B_x + C_x) / 3;
                    double Centroid_y = (A_y + B_y + C_y) / 3;
                    Console.WriteLine("Centroid of the ship is (" + String.Format("{0:0.0}", Centroid_x) + " " + String.Format("{0:0.0}", Centroid_y) + ")");
                    double Bisector_A = (2 * B_Length * C_Length * Math.Cos(Math.PI / 360 * A_angle)) / (B_Length + C_Length);
                    double Bisector_B = (2 * A_Length * C_Length * Math.Cos(Math.PI / 360 * B_angle)) / (A_Length + C_Length);
                    double Bisector_C = (2 * B_Length * A_Length * Math.Cos(Math.PI / 360 * C_angle)) / (B_Length + A_Length);
                    Console.WriteLine("Length of bisector A: " + String.Format("{0:0.0}", Bisector_A));
                    Console.WriteLine("Length of bisector B: " + String.Format("{0:0.0}", Bisector_B));
                    Console.WriteLine("Length of bisector C: " + String.Format("{0:0.0}", Bisector_C));
                    double AreaOfInscribedCircle = Math.Pow((2 * Area / (A_Length + B_Length + C_Length)), 2) * Math.PI;
                    Console.WriteLine("Area of the inscribed circle: " + String.Format("{0:0.0}", AreaOfInscribedCircle));
                    double AreaOfCircumscribedCircle = Math.Pow(((B_Length * C_Length * A_Length) / (4 * Area)), 2) * Math.PI;
                    Console.WriteLine("Area of the circumscribed circle: " + String.Format("{0:0.0}", AreaOfCircumscribedCircle));
                    if (A_Length == B_Length && B_Length == C_Length)
                    {
                        Console.WriteLine("The type of the ship: Equilateral " + "(Acute Angled)\n");

                    }
                    else if ((A_Length == B_Length) || (B_Length == C_Length) || (A_Length == C_Length))
                    {
                        if (A_angle < 90 && B_angle < 90 && C_angle < 90)
                        {
                            Console.WriteLine("The type of the ship: Isosceles" + " (Acute Angled)\n");
                        }
                        else if (A_angle == 90 || B_angle == 90 || C_angle == 90)
                        {
                            Console.WriteLine("The type of the ship: Isosceles" + " (Right Angled)\n");
                        }
                        else
                        {
                            Console.WriteLine("The type of the ship: Isosceles" + " (Obtuse Angled)\n");
                        }
                    }
                    else
                    {
                        if (A_angle < 90 && B_angle < 90 && C_angle < 90)
                        {
                            Console.WriteLine("The type of the ship: Scalene" + " (Acute Angled)\n");
                        }
                        else if (A_angle == 90 || B_angle == 90 || C_angle == 90)
                        {
                            Console.WriteLine("The type of the ship: Scalene" + " (Right Angled)\n");
                        }
                        else
                        {
                            Console.WriteLine("The type of the ship: Scalene" + " (Obtuse Angled)\n");
                        }

                    }
                }

                if (Choice == "3" && restart == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the coordinates of the ship first.\n");
                }
                else if (Choice == "3" && Area != 0 && restart)
                {
                    Console.Clear();
                    Console.WriteLine("12|\n11|\n10|\n 9|\n 8|\n 7|\n 6|\n 5|\n 4|\n 3|\n 2|\n 1|");       //Draw coordinate system
                    Console.WriteLine("  + _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                    Console.WriteLine("    1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0");
                    Console.SetCursorPosition(Convert.ToInt32((A_x * 2 + 2)), Convert.ToInt32((12 - A_y)));
                    Console.WriteLine("A");
                    Console.SetCursorPosition(Convert.ToInt32((B_x * 2 + 2)), Convert.ToInt32((12 - B_y)));
                    Console.WriteLine("B");
                    Console.SetCursorPosition(Convert.ToInt32((C_x * 2 + 2)), Convert.ToInt32((12 - C_y)));
                    Console.WriteLine("C");
                    Random atis = new Random();
                    double x = atis.Next(0, 31);
                    double y = atis.Next(0, 13);
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("A(" + A_x + "," + A_y + ")");
                    Console.WriteLine("B(" + B_x + "," + B_y + ")");
                    Console.WriteLine("C(" + C_x + "," + C_y + ")");
                    Console.WriteLine("Shoot X(" + x + "," + y + ")");

                    Area1 = Math.Abs((x * (B_y - C_y) + B_x * (C_y - y) + C_x * (y - B_y)) / 2);
                    Area2 = Math.Abs((A_x * (y - C_y) + x * (C_y - A_y) + C_x * (A_y - y)) / 2);
                    Area3 = Math.Abs((A_x * (B_y - y) + B_x * (y - A_y) + x * (A_y - B_y)) / 2);
                    Console.SetCursorPosition(Convert.ToInt32((x * 2 + 2)), Convert.ToInt32((12 - y)));
                    Console.WriteLine("X");
                    Console.SetCursorPosition(0, 20);
                    if ((Area1 + Area2 + Area3) == Area)
                    {
                        Console.WriteLine("The ship sank!\nYou gained 0 points");

                    }
                    else
                    {
                        Console.WriteLine("The ship survived!\nYou gained " + String.Format("{0:0.0}", Area) + " points\n");
                        Console.WriteLine("Please enter your name:");
                        string PlayerName = Console.ReadLine();
                        Console.WriteLine("\nScore saved\n");
                        Tempscore = Area;
                        restart = false;
                        if (Tempscore > FirstPlacePoint)
                        {
                            ThirdPlaceName = SecondPlaceName;
                            ThirdPlacePoint = SecondPlacePoint;
                            SecondPlaceName = FirstPlaceName;
                            SecondPlacePoint = FirstPlacePoint;
                            FirstPlaceName = PlayerName;
                            FirstPlacePoint = Tempscore;
                        }
                        else if (Tempscore > SecondPlacePoint)
                        {
                            ThirdPlaceName = SecondPlaceName;
                            ThirdPlacePoint = SecondPlacePoint;
                            SecondPlaceName = PlayerName;
                            SecondPlacePoint = Tempscore;
                        }
                        else if (Tempscore > ThirdPlacePoint)
                        {
                            ThirdPlaceName = PlayerName;
                            ThirdPlacePoint = Tempscore;
                        }

                    }

                }
                if (Choice == "4" && Area == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the coordinates of the ship first.\n");

                }
                else if (Choice == "4" && Area != 0)
                {   
                    string empty = Convert.ToString(ThirdPlacePoint);
                    empty = "--";
                    if (FirstPlaceName == "" && SecondPlaceName == "" && ThirdPlaceName == "")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tHIGH SCORE TABLE\n---------------------------------------------------");
                        Console.WriteLine("  Name\t\t\t\t\tScore");

                        Console.Write("  " + FirstPlaceName);
                        for (int i=0;i<40-FirstPlaceName.Length;i++)
                        {
                            Console.Write(" ");
                        }
                        
                         Console.Write(empty+"\n");

                        Console.Write("  " + SecondPlaceName);
                        
                        for (int i = 0; i < 40 - SecondPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(empty + "\n");
                        Console.Write("  " + ThirdPlaceName);
                        for (int i = 0; i < 40 - ThirdPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(empty + "\n");


                    }
                    else if (SecondPlaceName == "" && ThirdPlaceName == "")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tHIGH SCORE TABLE\n---------------------------------------------");
                        Console.WriteLine("  Name\t\t\t\t\tScore");
                        Console.Write("  " + FirstPlaceName );
                        for (int i = 0; i < 40 - FirstPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", FirstPlacePoint)+ "\n");
                        Console.Write("  " + SecondPlaceName );

                        for (int i = 0; i < 40 - SecondPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(empty + "\n");
                        Console.Write("  " + ThirdPlaceName);

                        for (int i = 0; i < 40 - ThirdPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(empty + "\n");
                    }
                    else if (ThirdPlaceName == "")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tHIGH SCORE TABLE\n---------------------------------------------");
                        Console.WriteLine("  Name\t\t\t\t\tScore");                      
                        Console.Write("  " + FirstPlaceName);
                        for (int i = 0; i < 40 - FirstPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", FirstPlacePoint )+"\n");                       
                        Console.Write("  " + SecondPlaceName);
                        for (int i = 0; i < 40 - SecondPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", SecondPlacePoint)+ "\n");                       
                        Console.Write("  " + ThirdPlaceName);
                        for (int i = 0; i < 40 - ThirdPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(empty + "\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tHIGH SCORE TABLE\n---------------------------------------------");
                        Console.WriteLine("  Name\t\t\t\t\tScore");
                        Console.Write("  " + FirstPlaceName);
                        for (int i = 0; i < 40 - FirstPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", FirstPlacePoint)+"\n");
                        Console.Write("  " + SecondPlaceName);
                        for (int i = 0; i < 40 - SecondPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", SecondPlacePoint)+ "\n");
                        Console.Write("  " + ThirdPlaceName);
                        for (int i = 0; i < 40 - ThirdPlaceName.Length; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(String.Format("{0:0.0}", ThirdPlacePoint)+ "\n\n");
                    }

                }


                else if (Choice == "5")
                {
                    Console.Clear();
                    System.Environment.Exit(0);
                }
            }
        }
    }
}

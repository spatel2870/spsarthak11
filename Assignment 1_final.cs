using System;

namespace Asiignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to The Super Store!!\n\n");
           
            Boolean whitePhone = false, bluePhone = false, blackPhone = false, blueTablet = false, greyTablet = false;
            double BluePhonePrice = 0, BlackPhonePrice = 0, WhitePhonePrice = 0, BlueTabletPrice = 0, GreyTabletPrice = 0;
            double BluePhoneDis = 0, BlackPhoneDis = 0, WhitePhoneDis = 0, BlueTabletDis = 0, GreyTabletDis = 0;
            double BluePhoneTotal = 0, BlackPhoneTotal = 0, WhitePhoneTotal = 0, BlueTabletTotal = 0, GreyTabletTotal = 0;
            int BluePhoneQty = 0, BlackPhoneQty = 0, WhitePhoneQty = 0, BlueTabletQty = 0, GreyTabletQty = 0;


            Boolean incorrect = false, checkout = false;


            do
            {
                string Type, color, ans, quantity;
                int quantityint = 0;
                double price = 0, discount = 0;

                do
                {
                    // ask a question 1

                    Console.WriteLine("\n=> Do you want iPhone or iPad?");
                    Type = Console.ReadLine();

                    // check the iPhone name is correct or not
                    if (Type == "iPhone" || Type == "iPad")
                    {
                        Console.WriteLine("\n- You selected " + Type);
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("\n- Sorry this " + Type + " not available in our inventory!");
                        incorrect = true;
                    }

                } while (incorrect == true) ;


                do
                {
                    if (Type == "iPhone")
                    {
                        // ask user to select a color for iphone from following list
                        Console.WriteLine("\n=> Select any colors for iPhone from the following list:\nblue\nblack\nwhite\n");
                        color = Console.ReadLine();

                        // check the iPhone color is valid or not
                        if (color == "white" || color == "blue" || color == "black")
                        {
                            Console.WriteLine("\n- You selected " + color + " phone!");
                            incorrect = false;

                            if (color == "blue")
                            {
                                Console.WriteLine("\n- The price of blue iPhone is 2000$");
                                price = 1689.00;
                            }
                            
                            if (color == "white")
                            {
                                Console.WriteLine("\n- The price of white iPhone is 1900$");
                                price = 1549.00;
                            }
                            
                            if (color == "black")
                            {
                                Console.WriteLine("\n- The price of black iPhone is 1800$");
                                price = 1599.00;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n- Sorry " + color + " iPhone not available in our inventory!");
                            incorrect = true;
                        }

                    }
                    else
                    {
                        // ask user to select a color for pixel from following list
                        Console.WriteLine("\n=> Select any colors for iPad from the following list:\nblue\ngrey\n");
                        color = Console.ReadLine();

                        // check the iPhone color is valid or not
                        if (color == "grey" || color == "blue")
                        {
                            Console.WriteLine("\n- You selected " + color + " Tablet");
                            incorrect = false;

                            if (color == "blue")
                            {
                                Console.WriteLine("\n- The price of blue iPad is 1550$");
                                price = 1049;
                            }
                            
                            if (color == "grey")
                            {
                                Console.WriteLine("\n- The price of grey iPad is 1500$");
                                price = 1099;
                            }

                        }
                        else
                        {
                            Console.WriteLine("\n- Sorry " + color + " iPad not available in our inventory!");
                            incorrect = true;
                        }
                    }
                } while (incorrect == true);

                do
                {
                    // ask user for quantity
                    Console.WriteLine("\n=> How many quantity you want ? (max=50)");
                    quantity = Console.ReadLine();
                    quantityint = int.Parse(quantity);

                    if (quantityint <= 50)
                    {
                        Console.WriteLine("\n- You have entered " + quantityint);
                        incorrect = false;
                        
                        if (quantityint >= 5)
                        {
                            Console.WriteLine("\n- Congrates you get 30% discount on " + Type + "!");
                            discount = 30;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n- Sorry your entered value is not correct.please enter again");
                        incorrect = true;
                    }
                } while (incorrect == true);

                do
                {
                    // ask user about student or senior citizen 
                    Console.WriteLine("\n=> Please give ans in yes or no if you are any of the following student or senior citizen or both ? [yes/no]");
                    ans = Console.ReadLine();
                    incorrect = true;

                    // check the category is correct or not
                    if (ans == "yes")
                    {

                        if (quantityint < 5)
                        {
                            Console.WriteLine("\n- Congrates you get 7% discount on " + Type + "!");
                            discount = 7;
                        }

                        incorrect = false;
                    }
                   
                    if (ans == "no")
                    {
                        incorrect = false;
                    }

                    if (ans != "yes" && ans != "no")
                    {
                        Console.WriteLine("\n- Sorry your answer is invalid, Please enter again!!");
                    }
                } while (incorrect == true);


                if (color == "blue" && Type == "iPhone")
                {
                    bluePhone = true;
                    BluePhonePrice = price;
                    BluePhoneQty = BluePhoneQty + quantityint; // add quantity if user order same item again
                   
                    if (BluePhoneQty > 5)
                    {
                        BluePhoneDis = 30;
                    }
                    else
                    {
                        BluePhoneDis = discount;
                    }
                    BluePhoneTotal = (BluePhonePrice * BluePhoneQty) * (1 - (BluePhoneDis / 100)); // total =(price * quantity) - discount%

                }
                if (color == "black" && Type == "iPhone")
                {
                    blackPhone = true;
                    BlackPhonePrice = price;
                    BlackPhoneQty = BlackPhoneQty + quantityint; // add quantity if user order same item again

                    if (BlackPhoneQty > 5)
                    {
                        BlackPhoneDis = 30;
                    }
                    else
                    {
                        BlackPhoneDis = discount;
                    }
                    BlackPhoneTotal = (BlackPhonePrice * BlackPhoneQty) * (1 - (BlackPhoneDis / 100)); // total =(price * quantity) - discount%
                }

                if (color == "white" && Type == "iPhone")
                {
                    whitePhone = true;
                    WhitePhonePrice = price;
                    WhitePhoneQty = WhitePhoneQty + quantityint; // add quantity if user order same item again

                    if (WhitePhoneQty > 5)
                    {
                        WhitePhoneDis = 30;
                    }
                    else
                    {
                        WhitePhoneDis = discount;
                    }
                    WhitePhoneTotal = (WhitePhonePrice * WhitePhoneQty) * (1 - (WhitePhoneDis / 100)); // total =(price * quantity) - discount%

                }

                if (color == "blue" && Type == "iPad")
                {
                    blueTablet = true;
                    BlueTabletPrice = price;
                    BlueTabletQty = BlueTabletQty + quantityint; // add quantity if user order same item again

                    if (BlueTabletQty > 5)
                    {
                        BlueTabletDis = 30;
                    }
                    else
                    {
                        BlueTabletDis = discount;
                    }
                    BlueTabletTotal = (BlueTabletPrice * BlueTabletQty) * (1 - (BlueTabletDis / 100)); // total =(price * quantity) - discount%

                }

                if (color == "grey" && Type == "iPad")
                {
                    greyTablet = true;
                    GreyTabletPrice = price;
                    GreyTabletQty = GreyTabletQty + quantityint; // add quantity if user order same item again

                    if (GreyTabletQty > 5)
                    {
                        GreyTabletDis = 30;
                    }
                    else
                    {
                        GreyTabletDis = discount;
                    }
                    GreyTabletTotal = (GreyTabletPrice * GreyTabletQty) * (1 - (GreyTabletDis / 100)); // total =(price * quantity) - discount%

                }

                do
                {
                    //ask user for checkout
                    Console.WriteLine("\n=> You want to check out ?[yes/no]");
                    ans = Console.ReadLine();
                    incorrect = true;

                    //check the category is correct or not
                    if (ans == "yes")
                    {
                        Console.WriteLine("\nThank you for respone ");
                        incorrect = false;
                        checkout = true;

                    }
                    if (ans == "no")
                    {
                       incorrect = false;
                    }
                   
                    if (ans != "yes" && ans != "no")
                    {
                        Console.WriteLine("\n- Sorry your answer is invalid, Please enter again!!");
                    }
                } while (incorrect == true);

            } while (checkout == false);

            //show user to printed bill
            Console.WriteLine("\n");
            Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15}", "Item type", "Details", "Cost per", "Qty", "Discount", "Total");
            Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15}", "---------", "-------", "--------", "---", "--------", "-----");

            double Totalsavings = 0, Tax = 0, SubTotal = 0;

            if (blackPhone == true)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "iPhone", "black", "$" + BlackPhonePrice, BlackPhoneQty, BlackPhoneDis + "%", BlackPhoneTotal);
                Totalsavings = (BlackPhoneQty * BlackPhonePrice) - BlackPhoneTotal;
                SubTotal = BlackPhoneTotal;
                Tax = (BlackPhoneTotal * 13) / 100;
            }
            
            if (bluePhone == true)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "iPhone", "blue", "$" + BluePhonePrice, BluePhoneQty, BluePhoneDis + "%", BluePhoneTotal);
                Totalsavings = Totalsavings + ((BluePhoneQty * BluePhonePrice) - BluePhoneTotal);
                SubTotal = SubTotal + BluePhoneTotal;
                Tax = Tax + ((BluePhoneTotal * 13) / 100);
            }
            
            if (whitePhone == true)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "iPhone", "white", "$" + WhitePhonePrice, WhitePhoneQty, WhitePhoneDis + "%", WhitePhoneTotal);
                Totalsavings = Totalsavings + ((WhitePhoneQty * WhitePhonePrice) - WhitePhoneTotal);
                SubTotal = SubTotal + WhitePhoneTotal;
                Tax = Tax + ((WhitePhoneTotal * 13) / 100);
            }
            
            if (blueTablet == true)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "iPad", "blue", "$" + BlueTabletPrice, BlueTabletQty, BlueTabletDis + "%", BlueTabletTotal);
                Totalsavings = Totalsavings + ((BlueTabletQty * BlueTabletPrice) - BlueTabletTotal);
                SubTotal = SubTotal + BlueTabletTotal;
                Tax = Tax + ((BlueTabletTotal * 13) / 100);
            }
            
            if (greyTablet == true)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "iPad", "grey", "$" + GreyTabletPrice, GreyTabletQty, GreyTabletDis + "%", GreyTabletTotal);
                Totalsavings = Totalsavings + ((GreyTabletQty * GreyTabletPrice) - GreyTabletTotal);
                SubTotal = SubTotal + GreyTabletTotal;
                Tax = Tax + ((GreyTabletTotal * 13) / 100);
            }

            double TotalPrice = SubTotal + Tax;
            Console.WriteLine("\n");
           
            if (Totalsavings != 0)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "", "", "", "", "Total savings:", Totalsavings);
                Console.WriteLine("\n");
            }
            Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "", "", "", "", "Sub Total:", SubTotal);
            Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "", "", "", "", "Tax:", Tax);
            Console.WriteLine("{0,-15}{1,-15}{2,15}{3,15}{4,15}{5,15:$0.00}", "", "", "", "", "Total", TotalPrice);

            Console.WriteLine("\n\nThank you for your purchase!!");
        }
    }
}
//uc1
UC1_Length lc = new UC1_Length();

//uc2
UC2_EqualityOFLine len1 = new UC2_EqualityOFLine();

bool Option = true;
while(Option)
{
    Console.Write("Select UC Number:\n1.Check Lenght of Line\n2.Check Equality of Two Lines\n");
    int checkoption = Convert.ToInt32(Console.ReadLine());
    switch(checkoption)
     {
        case 1:
            lc.Lengthcal();
            break;
        case 2:
            len1.checkequal();
          
            break;



    }
}
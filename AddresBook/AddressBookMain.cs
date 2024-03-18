using AddresBook;

public class AddressBookMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("adress book");

     
        AddEditDeleteContact a = new  AddEditDeleteContact();

        while (true)
        {
            Console.WriteLine("press 0 for add contact details\npress 1 for editing details\n press 2 for deleing  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 0: a.AddContactDetails(); break;
                case 1: a.EditContactDetails();break;
                case 2: a.DeleteContactDetails(); break;
            }
        }

    }
}